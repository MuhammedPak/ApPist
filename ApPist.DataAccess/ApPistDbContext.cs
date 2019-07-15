
using ApPist.Domain.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.DataAccess
{
    public class ApPistDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApPistDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<SliderImage>()
                .HasKey(i => new { i.ImageId, i.SliderId });

            builder.Entity<SliderImage>()
                .HasOne(s => s.Silder)
                .WithMany(i => i.SliderImages)
                .HasForeignKey(s => s.SliderId);

            builder.Entity<SliderImage>()
                .HasOne(i => i.Image)
                .WithMany(s => s.SliderImages)
                .HasForeignKey(i => i.ImageId);
        }

        DbSet<Image> Images { get; set; }
        DbSet<Slider> Slider { get; set; }
        DbSet<SliderImage> SliderImages { get; set; }
    }
}
