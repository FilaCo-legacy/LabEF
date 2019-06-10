using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace GtkApplication.Models
{
    public sealed class GrasshoppersContext : DbContext
    {
        private readonly DbContextOptions<GrasshoppersContext> _options;
        
        public DbSet<InventoryEntry> Inventories { get; set; }
        
        public DbSet <Item> Items { get; set; }
        
        public DbSet <Character> Characters { get; set; }
        
        public DbSet<GameSession> GameSessions { get; set; }
        
        public DbSet<Mission> Missions { get; set; }
        
        public DbSet<CharacterResultEntry> CharactersResults { get; set; }
        
        public GrasshoppersContext(DbContextOptions<GrasshoppersContext> options)
            : base(options)
        {
            _options = options;
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new MissionConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterResultEntryConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}