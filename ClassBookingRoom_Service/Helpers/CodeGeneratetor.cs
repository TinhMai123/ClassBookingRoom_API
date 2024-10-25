using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Helpers
{
    public class CodeGeneratetor
    {
        public static string GenerateBookingCode()
        {
            string prefix = "BOK";
            string timestamp = DateTime.Now.ToString("yyyyMMdd");
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            string orderCode = $"{prefix}-{timestamp}-{randomNumber}";
            return orderCode;
        }
    }
}
