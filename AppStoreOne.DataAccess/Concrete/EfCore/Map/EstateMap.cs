using AppStoreOne.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppStoreOne.DataAccess.Concrete.EfCore.Map
{
    public class EstateMap : IEntityTypeConfiguration<Estate>
    {
        public void Configure(EntityTypeBuilder<Estate> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).ValueGeneratedOnAdd();
            builder.Property(I => I.Ada).HasMaxLength(200);
            builder.Property(I => I.Adres).HasMaxLength(2000);
            builder.Property(I => I.Banyo).HasMaxLength(200);
            builder.Property(I => I.Baslik).HasMaxLength(500);
            builder.Property(I => I.Bilgi).HasMaxLength(5000);
            builder.Property(I => I.Blok).HasMaxLength(200);
            builder.Property(I => I.DaireNo).HasMaxLength(200);
            builder.Property(I => I.Durum).HasDefaultValue(0);
            builder.Property(I => I.EmlakTipi).HasDefaultValue(1);
            builder.Property(I => I.Il).HasMaxLength(200);
            builder.Property(I => I.Ilce).HasMaxLength(200);
            builder.Property(I => I.Kat).HasMaxLength(200);
            builder.Property(I => I.M2).HasDefaultValue(0);
            builder.Property(I => I.Oda).HasMaxLength(200);
            builder.Property(I => I.Pafta).HasMaxLength(200);
            builder.Property(I => I.Parsel).HasMaxLength(200);
            builder.Property(I => I.Salon).HasMaxLength(200);
            builder.Property(I => I.Semt).HasMaxLength(200);
            builder.Property(I => I.SiteAdi).HasMaxLength(200);




        }
    }
}
