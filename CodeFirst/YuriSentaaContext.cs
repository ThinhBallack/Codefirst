using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class YuriSentaa : DbContext
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
    }
}
