using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.IServices
{
    public interface IRedisService
    {

        void SetVerificationCode(string key, string value, TimeSpan expiration);
        string GetVerificationCode(string key);
        void DeleteVerificationCode(string key);
    }
}
