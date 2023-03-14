using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MVCProject.Models
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context() : base() { }

        //using during injection
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Delivery> Delivery { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AYA\SQL19;Initial Catalog=MVC_FinalProject;Integrated Security=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Payment>()
            .HasKey(p=>p.Id);

            builder.Entity<Order>()
                        .HasOne<Payment>(p => p.Payment)
                        .WithOne(s => s.Order)
                        .HasForeignKey<Payment>(s => s.OrderId);
            
            builder.Entity<Payment>()
                       .HasOne<Order>(p => p.Order)
                       .WithOne(s => s.Payment)
                       .HasForeignKey<Order>(s => s.PaymentId);


            builder.Entity<ApplicationUser>()
           .HasKey(c => c.Id);

            builder.Entity<Cart>()
                       .HasOne<ApplicationUser>(p => p.ApplicationUser)
                       .WithOne(s => s.Cart)
                       .HasForeignKey<ApplicationUser>(s => s.CartId);

            base.OnModelCreating(builder);



        }
    }
}
