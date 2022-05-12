using AppStoreOne.Dtos.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppStoreOne.Business.Validation
{
    public class CustomerAddDtoValidator: AbstractValidator<CustomerAddDto>
    {
        public CustomerAddDtoValidator()
        {

            RuleFor(I => I.MusteriAdi).MaximumLength(250).WithMessage("Müşteri Adı 250 Karakterden Çok Olamaz");
            RuleFor(I => I.MusteriAdi).NotEmpty().WithMessage("Müşteri Adı Boş Olamaz");
            RuleFor(I => I.IdentityNo).NotEmpty().WithMessage("Kimlik Bilgisi Boş Olamaz");
            RuleFor(I => I.IdentityNo).MaximumLength(200).WithMessage("Kimlik Bilgisi En Fazla 200 Karakter Olabilir ");
            RuleFor(I => I.Gsm).MaximumLength(200).WithMessage("Gsm En Fazla 200 Karakter Olabilir ");
            RuleFor(I => I.Fax).MaximumLength(200).WithMessage("Fax En Fazla 200 Karakter Olabilir ");
            RuleFor(I => I.Web).MaximumLength(200).WithMessage("Web Adresi En Fazla 200 Karakter Olabilir ");
            RuleFor(I => I.Telefon).MaximumLength(200).WithMessage("Telefon En Fazla 200 Karakter Olabilir ");
            RuleFor(I => I.Eposta).MaximumLength(200).WithMessage("E-Posta En Fazla 200 Karakter Olabilir ");
            RuleFor(I => I.Eposta).EmailAddress().WithMessage("Geçerli Bir E-Posta Adresi Giriniz");
            RuleFor(I => I.Adres1).MaximumLength(2000).WithMessage("Adres 1 En Fazla 200 Karakter Olabilir ");
            RuleFor(I => I.Adres2).MaximumLength(2000).WithMessage("Adres 2 En Fazla 200 Karakter Olabilir ");


        }
    }
}
