using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYSports1.Models.Identity
{
    public class KYSports1DbContext : IdentityDbContext<AppUser>
    {
        public KYSports1DbContext() : base("KYSports1")
        {

        }
    }
}