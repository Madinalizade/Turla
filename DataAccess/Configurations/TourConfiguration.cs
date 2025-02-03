using Core.Constants;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class TourConfiguration : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.ToTable("Tours");

            builder.Property(x => x.Id)
                .UseIdentityColumn(seed: DefaultConstantValues.DEFAULT_PRIMARY_KEY_INCREMENT_VALUE);

            builder.Property(x => x.TourName)
                .HasMaxLength(100).IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(500).IsRequired();

            builder.Property(x => x.Price)
              .IsRequired() 
              .HasColumnType("decimal(18,2)");
            builder.Property(x => x.StartDate)
                   .IsRequired(); 

            builder.Property(x => x.EndDate)
                   .IsRequired();

            builder.Property(x => x.PhotoURL)
                .HasMaxLength(150).IsRequired();

            builder.HasOne(x => x.Category)
              .WithMany(x => x.Tours) 
              .HasForeignKey(x => x.CategoryId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.TourRegions)
                   .WithOne(x => x.Tour) 
                   .HasForeignKey(x => x.TourId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
