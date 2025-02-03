using Core.Constants;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    
        public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
        {
            public void Configure(EntityTypeBuilder<Customer> builder)
            {
                builder.ToTable("Customer");

                builder.Property(x => x.Id)
                    .UseIdentityColumn(seed: DefaultConstantValues.DEFAULT_PRIMARY_KEY_INCREMENT_VALUE);

                builder.Property(x => x.CustomerName)
                    .HasMaxLength(50).IsRequired();

                builder.Property(x => x.CustomerSurname)
                    .HasMaxLength(50).IsRequired();

                builder.Property(x => x.PhoneNumber)
                   .HasMaxLength(15).IsRequired();

                builder.Property(x => x.Email)
                   .HasMaxLength(100).IsRequired();
                builder.HasIndex(x => x.Email);

                builder.Property(x => x.Password)
                  .HasMaxLength(5000).IsRequired();
            }
        }
    
}
