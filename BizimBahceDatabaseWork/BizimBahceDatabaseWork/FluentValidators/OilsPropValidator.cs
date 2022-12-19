using BizimBahceDatabaseWork.Models.Entities;
using FluentValidation;

namespace BizimBahceDatabaseWork.FluentValidators
{
    public class OilsPropValidator : AbstractValidator<OliveOilProperty>
    {
        public OilsPropValidator()
        {
            RuleFor(x => x.OliveOilDescription).NotNull().WithMessage("Özellik Alanı Boş Geçilemez !");
            RuleFor(x => x.OliveOilDescription).MinimumLength(20).WithMessage("Minimum 20 Karakter Giriniz !");
        }
    }
}
