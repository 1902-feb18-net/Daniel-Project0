using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RedRobin.DataAccess
{
    public partial class RedRobinContext : DbContext
    {
        public RedRobinContext()
        {
        }

        public RedRobinContext(DbContextOptions<RedRobinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<IngPro> IngPro { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ResIng> ResIng { get; set; }
        public virtual DbSet<ResPro> ResPro { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer", "RR");

                entity.HasIndex(e => e.CustPhone)
                    .HasName("UQ__Customer__6A97813029755F11")
                    .IsUnique();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustPhone)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<IngPro>(entity =>
            {
                entity.ToTable("IngPro", "RR");

                entity.Property(e => e.IngProId).HasColumnName("IngProID");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Qty).HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.IngPro)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IngPro");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.IngPro)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProIng");
            });

            modelBuilder.Entity<Ingredients>(entity =>
            {
                entity.HasKey(e => e.IngredientId)
                    .HasName("PK__Ingredie__BEAEB27AB4C1B379");

                entity.ToTable("Ingredients", "RR");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.IngCost).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.IngName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasKey(e => e.OrdProId)
                    .HasName("PK__OrderPro__E7B00264A2B9261D");

                entity.ToTable("OrderProduct", "RR");

                entity.Property(e => e.OrdProId).HasColumnName("OrdProID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProOrderProduct");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrdOrderProduct");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BAFA0334944");

                entity.ToTable("Orders", "RR");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrdCost).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Customer");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Restaurant");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "RR");

                entity.HasIndex(e => e.ProName)
                    .HasName("UQ__Product__D695FD1E24D0C686")
                    .IsUnique();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProCost).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ResIng>(entity =>
            {
                entity.ToTable("ResIng", "RR");

                entity.HasIndex(e => new { e.RestaurantId, e.IngredientId })
                    .HasName("UC_ResIng")
                    .IsUnique();

                entity.Property(e => e.ResIngId).HasColumnName("ResIngID");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.Qty).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.ResIng)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IngResIngPro");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.ResIng)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ResResIngPro");
            });

            modelBuilder.Entity<ResPro>(entity =>
            {
                entity.ToTable("ResPro", "RR");

                entity.Property(e => e.ResProId).HasColumnName("ResProID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ResPro)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ResPro");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.ResPro)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProRes");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurant", "RR");

                entity.HasIndex(e => e.RestLocation)
                    .HasName("UQ__Restaura__730ED115EC80656A")
                    .IsUnique();

                entity.HasIndex(e => e.RestPhone)
                    .HasName("UQ__Restaura__41D3E3889F1E1AF4")
                    .IsUnique();

                entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

                entity.Property(e => e.RestLocation)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RestPhone)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
