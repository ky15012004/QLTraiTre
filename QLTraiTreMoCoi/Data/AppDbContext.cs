using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using QLTraiTreMoCoi.Models;

namespace QLTraiTreMoCoi.Data
{
    public class AppDbContext : IdentityDbContext<NguoiDung>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DKGuiTre> DKGuiTres { get; set; }
        public DbSet<DKNhanNuoiTre> DKNhanNuoiTres { get; set; }
        public DbSet<LSCapNhatHoSoTre> LSCapNhatHoSoTres { get; set; }
        public DbSet<ThongTinTre> ThongTinTres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // === DKGuiTre => NguoiDung ===
            modelBuilder.Entity<DKGuiTre>()
                .HasOne(e => e.NguoiDung)
                .WithMany(u => u.DKGuiTres)
                .HasForeignKey(e => e.NguoiDungId)
                .OnDelete(DeleteBehavior.Restrict);

            // === DKNhanNuoiTre => NguoiDung ===
            modelBuilder.Entity<DKNhanNuoiTre>()
                .HasOne(e => e.NguoiDung)
                .WithMany(u => u.DKNhanNuoiTres)
                .HasForeignKey(e => e.NguoiDungId)
                .OnDelete(DeleteBehavior.Restrict);

            // === DKNhanNuoiTre => ThongTinTre ===
            modelBuilder.Entity<DKNhanNuoiTre>()
                .HasOne(e => e.ThongTinTre)
                .WithMany()
                .HasForeignKey(e => e.TreId)
                .OnDelete(DeleteBehavior.Restrict);

            // === LSCapNhatHoSoTre => NguoiDung ===
            modelBuilder.Entity<LSCapNhatHoSoTre>()
                .HasOne(e => e.NguoiDung)
                .WithMany(u => u.CapNhatHoSoTres)
                .HasForeignKey(e => e.NguoiDungId)
                .OnDelete(DeleteBehavior.Restrict);

            // === LSCapNhatHoSoTre => ThongTinTre ===
            modelBuilder.Entity<LSCapNhatHoSoTre>()
                .HasOne(e => e.ThongTinTre)
                .WithMany()
                .HasForeignKey(e => e.TreId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
