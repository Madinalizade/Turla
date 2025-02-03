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
    public class TourRegionConfiguration : IEntityTypeConfiguration<TourRegion>
    {
        public void Configure(EntityTypeBuilder<TourRegion> builder)
        {
            builder.ToTable("TourRegions");

            builder.Property(x => x.Id)
                .UseIdentityColumn(seed: DefaultConstantValues.DEFAULT_PRIMARY_KEY_INCREMENT_VALUE);

            // Composite Primary Key
            builder.HasKey(tr => new { tr.TourId, tr.RegionId });

          
            builder.HasOne(x => x.Tour)
                   .WithMany(x => x.TourRegions) 
                   .HasForeignKey(x => x.TourId)
                   .OnDelete(DeleteBehavior.Cascade); 

            builder.HasOne(x => x.Region)
                   .WithMany(x => x.TourRegions) 
                   .HasForeignKey(x => x.RegionId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
