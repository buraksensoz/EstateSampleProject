using AppStoreOne.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppStoreOne.DataAccess.Concrete.EfCore.Map
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).ValueGeneratedOnAdd();
            builder.Property(I => I.MusteriAdi).HasMaxLength(250);
            builder.Property(I => I.Telefon).HasMaxLength(200);
            builder.Property(I => I.Adres1).HasMaxLength(2000);
            builder.Property(I => I.Adres2).HasMaxLength(2000);
            builder.Property(I => I.Gsm).HasMaxLength(200);
            builder.Property(I => I.Fax).HasMaxLength(200);
            builder.Property(I => I.Web).HasMaxLength(200);
            builder.Property(I => I.Eposta).HasMaxLength(200);
            builder.Property(I => I.IdentityNo).HasMaxLength(200);
            builder.Property(I => I.MusteriTip).HasDefaultValue(1);
            builder.Property(I => I.MusteriBilgi).HasMaxLength(5000);
            builder.HasMany(I => I.Estates).WithOne(I => I.Sahip).HasForeignKey(I => I.SahipId);
            builder.Property(I => I.Banka).HasMaxLength(200);
            builder.Property(I => I.BankaSube).HasMaxLength(200);
            builder.Property(I => I.Iban).HasMaxLength(200);
        }
    }
}
