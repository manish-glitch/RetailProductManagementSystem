using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProceedToBuyRepository.Models
{
    public partial class ProceedToBuyDBContext : DbContext
    {
        public ProceedToBuyDBContext()
        {
        }

        public ProceedToBuyDBContext(DbContextOptions<ProceedToBuyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorStock> VendorStocks { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.; Database=ProceedToBuyDB; integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.Property(e => e.CartId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Cart__CustomerId__534D60F1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Cart__ProductId__52593CB8");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK__Cart__VendorId__5441852A");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.VendorId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VendorStock>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.ProductId })
                    .HasName("PK__VendorSt__37C6D49FF133A251");

                entity.ToTable("VendorStock");

                entity.Property(e => e.VendorId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<WishList>(entity =>
            {
                entity.ToTable("WishList");

                entity.Property(e => e.WishListId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AddedToWishlistDate).HasColumnType("date");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__WishList__Custom__5BE2A6F2");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__WishList__Produc__5AEE82B9");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK__WishList__Vendor__59FA5E80");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
