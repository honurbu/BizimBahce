using BizimBahceDatabaseWork.Models.Entities;
using FluentValidation;

namespace BizimBahceDatabaseWork.FluentValidators
{
    public class OilsValidator:AbstractValidator<OliveOil>
    {
        public OilsValidator()
        {
            RuleFor(x => x.OliveOilPrice.OliveOilPriceLiter).NotNull().WithMessage("Fiyat Alanı Boş Geçilemez !");
            RuleFor(x => x.OliveOilBenefit.OliveOilBenefitDescription).NotNull().WithMessage("Yararlar Alanı Boş Geçilemez !");
            RuleFor(x => x.OliveOilType.OliveOilDescription).NotNull().WithMessage("Tür Alanı Boş Geçilemez !");
            RuleFor(x => x.OliveOilProperty.OliveOilDescription).NotNull().WithMessage("Özellik Alanı Boş Geçilemez !");
            RuleFor(x => x.OliveOilProperty.OliveOilDescription).MinimumLength(20).WithMessage("Minimum 10 Karakter Giriniz !");
            RuleFor(x => x.OliveOilProperty.OliveOilAsidic).NotNull().WithMessage("Asit Oranı Boş Geçilemez !");
            RuleFor(x => x.OliveOilProperty.OliveOilLiter).NotNull().WithMessage("Litre alanı Boş Geçilemez !");

        }
    }
}
