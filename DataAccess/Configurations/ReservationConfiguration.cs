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
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservation");

            builder.Property(x => x.Id)
                .UseIdentityColumn(seed: DefaultConstantValues.DEFAULT_PRIMARY_KEY_INCREMENT_VALUE);

            builder.Property(x => x.Status)
                .HasMaxLength(250).IsRequired();

            builder.Property(x => x.ReservationDate)
                .IsRequired();

            builder.Property(x => x.Status)
                .HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Customer)
               .WithMany(x => x.Reservations)
               .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.Tour)
                   .WithMany(x => x.Reservations)
                   .HasForeignKey(x => x.TourId);
        }
    }
}
