using AppStoreOne.Dtos.Dtos;
using FluentValidation;

namespace AppStoreOne.Business.Validation
{
    public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateDtoValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez.");
            RuleFor(I => I.FullName).NotEmpty().WithMessage("İsim Soyad Boş Geçilemez.");
            RuleFor(I => I.Email).NotEmpty().WithMessage("Email Boş Geçilemez.");
            RuleFor(I => I.Email).EmailAddress().WithMessage("Geçerli Bir Mail Adresi Giriniz.");
        }
    }
}
