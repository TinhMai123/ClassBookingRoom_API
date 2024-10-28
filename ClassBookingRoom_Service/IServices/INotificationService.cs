using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface INotificationService
    {
        Task<bool> NotifyManager(string title, string body);
    }
}
