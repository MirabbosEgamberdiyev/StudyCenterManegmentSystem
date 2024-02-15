using Domain.Entities.CRM;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Fan> Fans {  get; set; }
        public DbSet<Guruh> Guruhs  { get; set; }
        public DbSet<Talaba> Talabas  { get; set; }
        public DbSet<TalabaGuruh> TalabaGuruhs { get; set; }
        public DbSet<TalabaGuruhDavomat> TalabaGuruhDavomats { get; set; }
        public DbSet<TalabaTolov> TalabaTolovs { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherFan> TeacherFans { get; set; }
        public DbSet<Xona> Xonas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Your configurations here

            base.OnModelCreating(builder);
        }
    }
}