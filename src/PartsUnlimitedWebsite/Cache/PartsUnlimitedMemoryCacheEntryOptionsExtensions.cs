using System;

namespace PartsUnlimited.Cache
{
    public static class PartsUnlimitedMemoryCacheEntryOptionsExtensions
    {
        /// <summary>
        /// Sets the priority for keeping the cache entry in the cache during a memory pressure tokened cleanup.
        /// 
        /// </summary>
        /// <param name="options"/><param name="priority"/>
        public static PartsUnlimitedMemoryCacheEntryOptions SetPriority(this PartsUnlimitedMemoryCacheEntryOptions options, PartsUnlimitedCacheItemPriority priority)
        {
            options.Priority = priority;
            return options;
        }

        /// <summary>
        /// Sets an absolute expiration time, relative to now.
        /// 
        /// </summary>
        /// <param name="options"/><param name="relative"/>
        public static PartsUnlimitedMemoryCacheEntryOptions SetAbsoluteExpiration(this PartsUnlimitedMemoryCacheEntryOptions options, TimeSpan relative)
        {
            options.AbsoluteExpirationRelativeToNow = relative;
            return options;
        }

        /// <summary>
        /// Sets how long the cache entry can be inactive (e.g. not accessed) before it will be removed.
        ///             This will not extend the entry lifetime beyond the absolute expiration (if set).
        /// 
        /// </summary>
        /// <param name="options"/><param name="offset"/>
        public static PartsUnlimitedMemoryCacheEntryOptions SetSlidingExpiration(this PartsUnlimitedMemoryCacheEntryOptions options, TimeSpan offset)
        {
            options.SlidingExpiration = offset;
            return options;
        }
    }
}