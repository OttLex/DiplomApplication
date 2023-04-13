using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ModelRelations;
using Model.ModelSpr;
using Model.ModelsSpr;

namespace Model.EF
{
    public class AppDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ScenarioEditor;Trusted_Connection=True;");
            
        }

        public DbSet<Morph> Morph => Set<Morph>();
        public DbSet<ObjectCast> ObjectCast => Set<ObjectCast>();
        public DbSet<Script> Script => Set<Script>();
        public DbSet<Activity> Activity => Set<Activity>();
        public DbSet<ActivityType> ActivityType => Set<ActivityType>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Access> Access => Set<Access>();
        public DbSet<Background> Background => Set<Background>();
        public DbSet<Block> Block => Set<Block>();
        public DbSet<ListOfScripts> ListOfScripts => Set<ListOfScripts>();

        //public DbSet<CastType> CastType => Set<CastType>();
        public DbSet<CastTypes> CastTypes => Set<CastTypes>();
        public DbSet<Objects> Objects => Set<Objects>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Script>()
            .HasIndex(u => u.NumberOfStep)
            .IsUnique();

            modelBuilder.Entity<User>().HasData(
                        new User { Id = 1, UserName = "dev", Password = "123", AccessLevelId=1 },
                        new User { Id = 2, UserName = "reader", Password = "123", AccessLevelId = 2 });

            modelBuilder.Entity<Access>().HasData(
                        new Access { Id = 1, Name = "Developer" },
                        new Access { Id = 2, Name = "Reader"});
        }

        public AppDBContext() 
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

    }
}
