using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Gsys.Mvc.Controllers.Shared
{
    public class AppUser : ClaimsPrincipal
    {
        public AppUser(ClaimsPrincipal principal)
            : base(principal)
        {
        }

        public long UserId => Convert.ToInt64(FindFirst(ClaimTypes.NameIdentifier).Value);

        public string Country => FindFirst(ClaimTypes.Country).Value ?? string.Empty;

        public string Email => FindFirst(ClaimTypes.Email).Value;

        public string PerfilName => FindFirst(ClaimTypes.Role).Value;

        public string Login => FindFirst("Login").Value;
        
        public IEnumerable<int> IdsMenu => FindFirst("IdsMenu").Value?.Split('|').Select(int.Parse);
    }
}