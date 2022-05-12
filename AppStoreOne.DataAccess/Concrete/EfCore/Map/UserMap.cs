using AppStoreOne.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppStoreOne.DataAccess.Concrete.EfCore.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).ValueGeneratedOnAdd();
            builder.Property(I => I.Email).HasMaxLength(200);
            builder.Property(I => I.UserName).HasMaxLength(200);
            builder.Property(I => I.FullName).HasMaxLength(200);
            builder.Property(I => I.Password).HasMaxLength(200);
            builder.Property(I => I.PhoneNumber).HasMaxLength(200);
            builder.Property(I => I.AuthType).HasDefaultValue(0);

        }
    }
}
