using EFCodeFirstApp.Models.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

// yapılan işlemlerin db ye aktarım yapılmaya başlaması için bir sefer enable-migrations komutu package manager console da çağrılmalı
// SQL e aktarım (migration) için package manager da update-database komutu çalıştırılır
// SQL e aktarım sırasında yapılamazsa update-database -force dene

namespace EFCodeFirstApp.Models.Data.DBContext
{
    public class InternetDBContext : DbContext
    {
        public InternetDBContext()
        {
            //connectionstrig belirtilir
            Database.Connection.ConnectionString = Config.ConnectionString;
        }

        //model oluşturulduğu zaman çağrılır
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //db de oluşturulcak olan tabloların sonuna 's' takısı vermeyi önler
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //SQL de classların birebir karşılığı DbSet tipindeki propertylerdir
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}