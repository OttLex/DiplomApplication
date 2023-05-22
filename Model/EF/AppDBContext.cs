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
        string _connetctionString = "";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connetctionString);

            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ScenarioEditor;Trusted_Connection=True;");
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
        //public DbSet<ListOfScripts> ListOfScripts => Set<ListOfScripts>();

        public DbSet<CastTypes> CastTypes => Set<CastTypes>();
        public DbSet<Objects> Objects => Set<Objects>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                        new User { Id = 1, Name = "dev", Password = "123", AccessLevelId=1 },
                        new User { Id = 2, Name = "reader", Password = "123", AccessLevelId = 2 });

            modelBuilder.Entity<Access>().HasData(
                        new Access { Id = 1, Name = "Developer" },
                        new Access { Id = 2, Name = "Reader"});

            modelBuilder.Entity<Script>().HasData(
                            new Script { Id = 1, Name = "First scenario" },
                            new Script { Id = 2, Name = "Second scenario", Description= "Same as first, but coller!" });

            modelBuilder.Entity<ActivityType>().HasData(
                            new ActivityType { Id = 1, Name = "Zoom" },
                            new ActivityType { Id = 2, Name = "Hidden object"},
                            new ActivityType { Id = 3, Name = "Dialog"},
                            new ActivityType { Id = 4, Name = "Mini-game" },
                            new ActivityType { Id = 5, Name = "Cat-scene" });
        }

        public AppDBContext(string connString) 
        {
            _connetctionString=connString;
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

    }
}
