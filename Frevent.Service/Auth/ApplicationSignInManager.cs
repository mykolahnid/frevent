using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Frevent.Model.Models.Auth;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace Frevent.Service.Auth
{
    public class ApplicationSignInManager : SignInManager<AspNetUser, string>
    {
        public ApplicationSignInManager(AspNetUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(AspNetUser user)
        {
            return user.GenerateUserIdentityAsync((AspNetUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<AspNetUserManager>(), context.Authentication);
        }
    }
}
