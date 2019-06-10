using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Grasshoppers.Models
{
    public sealed class GrasshoppersContext : DbContext
    {
        public DbSet<InventoryEntry> Inventories { get; set; }
        
        public DbSet <Item> Items { get; set; }
        
        public DbSet <Character> Characters { get; set; }
        
        public DbSet<GameSession> GameSessions { get; set; }
        
        public DbSet<Mission> Missions { get; set; }
        
        public DbSet<CharacterResultEntry> CharactersResults { get; set; }
        
        public GrasshoppersContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=EFLabDB;Username=filaco;Password=gehunu94");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
            modelBuilder.ApplyConfiguration(new MissionConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterResultEntryConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}