using ClassBookingRoom_Repository.Repos;
using ClassBookingRoom_Service.IServices;
using Expo.Server.Client;
using Expo.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class NotificationService : INotificationService
    {
        private readonly UserRepo _userRepo;

        public NotificationService(UserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<bool> NotifyManager(string title, string body)
        {
            var users = await _userRepo.GetAllUser();
            var managers = users.Where(u => u.Role == "Manager" && !string.IsNullOrEmpty(u.PushToken));
            if (!managers.Any())
            {
                return true;
            }
            try
            {
                var expoSDKClient = new PushApiClient();
                var pushTicketReq = new PushTicketRequest()
                {
                    PushTo = managers.Select(u => u.PushToken).ToList(),
                    PushBadgeCount = 1,
                    PushBody = body,
                    PushTitle = title
                };
                var result = await expoSDKClient.PushSendAsync(pushTicketReq);

                if (result?.PushTicketErrors?.Count > 0)
                {
                    foreach (var error in result.PushTicketErrors)
                    {
                        Console.WriteLine($"Error: {error.ErrorCode} - {error.ErrorMessage}");
                    }
                }
            } catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
