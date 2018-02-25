using KYSports1.Models.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace KYSports1.App_Start
{
        public class IdentityConfig
        {
            public void Configuration(IAppBuilder app)
            {
                app.CreatePerOwinContext(() => new KYSports1DbContext());

                app.CreatePerOwinContext<UserManager<AppUser>>((options, context) =>
                    new UserManager<AppUser>(
                        new UserStore<AppUser>(context.Get<KYSports1DbContext>())));

                app.CreatePerOwinContext<RoleManager<AppRole>>((options, context) =>
                    new RoleManager<AppRole>(
                        new RoleStore<AppRole>(context.Get<KYSports1DbContext>())));

                app.UseCookieAuthentication(new CookieAuthenticationOptions
                {
                    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                    LoginPath = new PathString("/Home/Login"),
                });
            }
        }
    }