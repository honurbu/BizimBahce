using BizimBahceDatabaseWork.Models.Entities;
using FluentValidation;

namespace BizimBahceDatabaseWork.FluentValidators
{
    public class OilsPropValidator : AbstractValidator<OliveOilProperty>
    {
        public OilsPropValidator()
        {
            RuleFor(x => x.OliveOilDescription).NotNull().WithMessage("Özellik Alanı Boş Geçilemez !");
            RuleFor(x => x.OliveOilDescription).MinimumLength(10).WithMessage("Miinmum 10 Karakter Giriniz !");
        }
    }
}
