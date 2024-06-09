using RedLockNet.SERedis;
using RedLockNet.SERedis.Configuration;
using StackExchange.Redis;

namespace Integration.Service
{
    public static class RedisService
    {
        static readonly ConnectionMultiplexer _redis = ConnectionMultiplexer.Connect("localhost:6379");

        public static RedLockFactory GetRedlockFactory()
        {
            var multiplexer = new List<RedLockMultiplexer> { _redis };

            var redlockFactory = RedLockFactory.Create(multiplexer);

            return redlockFactory;
        }
    }
}
