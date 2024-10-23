using System;
using System.Security.Cryptography;
using System.Text;

namespace ClassBookingRoom_Service.Helpers
{
    public class EmailHelper
    {
        public static string GenerateVerificationToken(string email)
        {
            var tokenData = email + DateTime.UtcNow.ToString("o");
            using (var sha256 = SHA256.Create())
            {
                var tokenBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(tokenData));
                return Convert.ToBase64String(tokenBytes)
                    .Replace("+", "")
                    .Replace("/", "")
                    .Replace("=", "");
            }
        }
        public static bool IsCompanyEmail(string email, string companyDomain)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            email = email.ToLower();
            return email.EndsWith("@" + companyDomain.ToLower());
        }
    }
}