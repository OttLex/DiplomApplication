using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ModelRelations;
using Model.ModelsSpr;

namespace Model.EF
{
    public class AppDBContext:DbContext
    {
        public DbSet<Morph> Morph=> Set<Morph>();
        public DbSet<ObjectCast> ObjectCast => Set<ObjectCast>();
        public DbSet<Script> Script => Set<Script>();
        public DbSet<Activity> Activity => Set<Activity>();
        public DbSet<ActivityType> ActivityType => Set<ActivityType>();
        public DbSet<Background> Background => Set<Background>();
        public DbSet<Block> Block => Set<Block>();
        public DbSet<CastType> CastType => Set<CastType>();
        public DbSet<CastTypes> CastTypes => Set<CastTypes>();
        public DbSet<Objects> Objects => Set<Objects>();

        public AppDBContext() => Database.EnsureCreated();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ScenarioEditor;Trusted_Connection=True;");
        }
    }
}
