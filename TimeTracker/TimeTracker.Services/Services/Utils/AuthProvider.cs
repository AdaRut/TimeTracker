using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Claims;
using TimeTracker.Services.Interfaces.Services.Utils;

namespace TimeTracker.Services.Services.Utils
{
    public class AuthProvider : IAuthProvider
    {
        private readonly IHttpContextAccessor _context;

        public AuthProvider(IHttpContextAccessor context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public string GetUserId()
        {
            return _context.HttpContext.User.Claims
                       .First(i => i.Type == ClaimTypes.NameIdentifier).Value;
        }
    }
}
