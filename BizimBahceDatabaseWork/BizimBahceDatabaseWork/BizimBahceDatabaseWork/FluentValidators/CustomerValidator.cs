using BizimBahceDatabaseWork.Models.Entities;
using FluentValidation;

namespace BizimBahceDatabaseWork.FluentValidators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotNull().WithMessage("Ad Alanı Boş Geçilemez !");
            RuleFor(x => x.CustomerSurname).NotNull().WithMessage("Ad Alanı Boş Geçilemez !");
            RuleFor(x => x.CustomerProvince).NotNull().WithMessage("Ad Alanı Boş Geçilemez !");
            RuleFor(x => x.CustomerMail).NotNull().WithMessage("Ad Alanı Boş Geçilemez !");
        }
    }
}
