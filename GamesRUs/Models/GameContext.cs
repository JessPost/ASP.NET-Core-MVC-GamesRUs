using Microsoft.EntityFrameworkCore;

namespace GamingStore.Models
{
    public class GameContext : DbContext
    {
        public DbSet<Auth> Auths { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Game> Games { get; set; }

        public GameContext(DbContextOptions<GameContext> options) : base(options) { }
    }
}
