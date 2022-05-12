using AppStoreOne.Dtos.EstateTypeDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStoreOne.Business.Validation.EstateValidator
{
    public class EstateDaireDtoValidator:AbstractValidator<EstateDto>
    {
        public EstateDaireDtoValidator()
        {
            RuleFor(I => I.Baslik).NotEmpty().WithMessage("Başlık Girilmelidir");
            RuleFor(I => I.Il).NotEmpty().WithMessage("Şehir Seçilmelidir");
            RuleFor(I => I.Ilce).NotEmpty().WithMessage("İlçe Seçilmelidir");
            RuleFor(I => I.Semt).NotEmpty().WithMessage("Mahalle Seçilmelidir");
            RuleFor(I => I.Fiyat).ExclusiveBetween(1.0,1000000000.0).WithMessage("Fiyat 1 TL -1 Milyar TL Arasında Olmalıdır.");
            RuleFor(I => I.SahipId).GreaterThan(0).WithMessage("Mülk Sahibi Seçilmelidir.");
            RuleFor(I => I.M2).GreaterThan(0).WithMessage("Metre Kare Girilmelidir");
        }
    }
}
