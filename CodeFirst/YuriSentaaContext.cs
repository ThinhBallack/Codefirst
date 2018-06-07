using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace CodeFirst
{
    public class YuriSentaa : IdentityDbContext
    {
        //Khoi tao db trung tam Yuri
        public YuriSentaa() : base("DefaultConnection")
        {

        }
        static YuriSentaa()
        {
            Database.SetInitializer<YuriSentaa>(new IdentityDbInit());
        }
        public static YuriSentaa Create()
        {
            return new YuriSentaa();
        }
        public DbSet<Gakusei> Gakusei { get; set; }
        public DbSet<Kulasu> Kulasu { get; set; }
        public DbSet<Koushi> Koushi { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        internal class IdentityDbInit : DropCreateDatabaseIfModelChanges<YuriSentaa>
        {
            public void Seed(YuriSentaa context)
            {
                PerformInit();
                base.Seed(context);
            }

            public void PerformInit()
            {

            }
        }
        public void PerformInitialSetup(YuriSentaa context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<Account>(new UserStore<Account>(context));

            roleManager.Create(new IdentityRole()
            {
                Name = "Admin"
            });

            roleManager.Create(new IdentityRole()
            {
                Name = "User"
            });

            Account account = new Account()
            {
                UserName = "admin",
                Email = "admin@test.com",
                EmailConfirmed = true
            };

            userManager.Create(account, "Abc123!!!");

            userManager.AddToRole(account.Id, "Admin");
        }
    }
}
