using GamesNexus.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Concurrent;
using static GamesNexus.Common.GeneralApplicationConstants;

namespace GamesNexus.Web.Infrastructure.MIddlewares
{
    public class OnlineUsersMiddleware
    {
        private readonly RequestDelegate next;
        private readonly string cookieName;
        private readonly int lastActivityMinutes;

        private static readonly ConcurrentDictionary<string,bool> AllKeys = new ConcurrentDictionary<string, bool>();

        public OnlineUsersMiddleware(RequestDelegate _next,  int _lastActivityMinutes = LastActivityBeforeOfflineMinutes, string _cookieName = OnlineUsersCookieName)
        {
            this.next = _next;
            this.cookieName = _cookieName;
            this.lastActivityMinutes = _lastActivityMinutes;
        }

        public Task Invoke(HttpContext context, IMemoryCache memoryCache)
        {
            if (context.User.Identity?.IsAuthenticated ?? false)
            {
                if (!context.Request.Cookies.TryGetValue(this.cookieName, out string userId))
                {
                    userId = context.User.GetId()!;

                    context.Response.Cookies.Append(this.cookieName,userId,new CookieOptions()
                    {
                        HttpOnly = true,
                        MaxAge = TimeSpan.FromDays(30)
                    });
                }

                memoryCache.GetOrCreate(userId, cacheEntry =>
                {
                    if (AllKeys.TryAdd(userId, true))
                    {
                        cacheEntry.AbsoluteExpiration = DateTimeOffset.MinValue;
                    }
                    else
                    {
                        cacheEntry.SlidingExpiration = TimeSpan.FromMinutes(this.lastActivityMinutes);
                        cacheEntry.RegisterPostEvictionCallback(this.RemoveKeyWhenExpired);
                    }

                    return string.Empty;
                });
            }
            else
            {
                if (context.Request.Cookies.TryGetValue(this.cookieName, out string userId))
                {
                    if (AllKeys.TryRemove(userId, out _))
                    {
                        AllKeys.TryUpdate(userId, false, true);
                    }

                    context.Response.Cookies.Delete(this.cookieName);
                }
            }

            return this.next(context);
        }

        public static bool CheckIfUserIsOnline(string userId)
        {
            bool valuetaken = AllKeys.TryGetValue(userId.ToLower(), out bool success);

            return success && valuetaken;
        }



        private void RemoveKeyWhenExpired(object key, object value, EvictionReason reason,object state )
        {
            string keyStr = (string)key;

            if (AllKeys.TryRemove(keyStr, out _))
            {
                AllKeys.TryUpdate(keyStr, false, true);
            }
        }
    }
}
