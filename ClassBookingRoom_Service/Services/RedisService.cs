
using ClassBookingRoom_Service.IServices;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookingRoom_Service.Services
{
    public class RedisService : IRedisService
    {
        private readonly ConnectionMultiplexer _redis;

        public RedisService(string connectionString)
        {
            _redis = ConnectionMultiplexer.Connect(connectionString);
        }

        public IDatabase GetDatabase()
        {
            return _redis.GetDatabase();
        }
        public void SetVerificationCode(string key, string value, TimeSpan expiration)
        {
            GetDatabase().StringSet(key, value, expiration);
        }

        public string GetVerificationCode(string key)
        {
            return GetDatabase().StringGet(key);
        }
        public void DeleteVerificationCode(string key)
        {
            GetDatabase().KeyDelete(key);
        }
    }
}
