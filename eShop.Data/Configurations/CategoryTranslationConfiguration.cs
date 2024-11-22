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
    public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.LanguageId).IsUnicode(false).HasMaxLength(5);

            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.SeoDescription).HasMaxLength(200);
            builder.Property(x => x.SeoTitle).HasMaxLength(50);
            builder.Property(x => x.SeoAlias).HasMaxLength(200);

            builder.HasOne(x => x.Category).WithMany(x=>x.CategoryTranslations).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Language).WithMany(x => x.CategoryTranslations).HasForeignKey(x => x.LanguageId);

        }
    }
}
