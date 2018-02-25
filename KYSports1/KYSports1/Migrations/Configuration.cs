namespace KYSports1.Migrations
{
    using KYSports1.Models.Identity;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KYSports1.Models.Identity.KYSports1DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KYSports1.Models.Identity.KYSports1DbContext context)
        {
            // Load the user and role managers with our custom models
            var userMgr = new UserManager<AppUser>(new UserStore<AppUser>(context));
            var roleMgr = new RoleManager<AppRole>(new RoleStore<AppRole>(context));

            // have we loaded roles already?
            if (roleMgr.RoleExists("admin"))
                return;

            // create the admin role
            roleMgr.Create(new AppRole() { Name = "admin" });

            // create the default user
            var user = new AppUser()
            {
                UserName = "admin"
            };

            // create the user with the manager class
            userMgr.Create(user, "Wildcat1");

            // add the user to the admin role
            userMgr.AddToRole(user.Id, "admin");
        }
    }
}
