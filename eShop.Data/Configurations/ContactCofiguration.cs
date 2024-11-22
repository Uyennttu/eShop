using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.Configurations
{
    public class ContactCofiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x=>x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().IsUnicode(false).HasMaxLength(100);
            builder.Property(x => x.PhoneNumber).IsRequired();
        }
    }
}
