using AppStoreOne.Dtos.Dtos;
using FluentValidation;

namespace AppStoreOne.Business.Validation
{
    public class UserAddDtoValidator : AbstractValidator<UserAddDto>
    {
        public UserAddDtoValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez.");
            RuleFor(I => I.FullName).NotEmpty().WithMessage("İsim Soyad Boş Geçilemez.");
            RuleFor(I => I.Email).NotEmpty().WithMessage("Email Boş Geçilemez.");
            RuleFor(I => I.Email).EmailAddress().WithMessage("Geçerli Bir Mail Adresi Giriniz.");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Parola Boş Geçilemez.");
            RuleFor(I => I.Password).MinimumLength(8).WithMessage("Parola En Az 8 Karakter Olmalıdır");
            RuleFor(I => I.Password).MaximumLength(32).WithMessage("Parola En Az 32 Karakter Olmalıdır");
            RuleFor(I => I.Password).Matches(@"[A-Z]+").WithMessage("Parola En Az 1 Büyük Karakter İçermelidir");

        }
    }
}
