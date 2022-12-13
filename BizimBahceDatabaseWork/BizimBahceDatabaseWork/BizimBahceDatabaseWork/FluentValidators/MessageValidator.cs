using BizimBahceDatabaseWork.Models.Entities;
using FluentValidation;

namespace BizimBahceDatabaseWork.FluentValidators
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x=>x.MsgOwner).NotNull().WithMessage("Mesaj Sahibinin Adı-Soyadı Boş Geçilemez !");
            RuleFor(x=>x.MsgOwner).MaximumLength(50).MinimumLength(3).WithMessage("Mesaj Sahibinin Adı-Soyadı 3-50 Karakter Arasında Olmalıdır ! ");
            RuleFor(x=>x.MsgMail).NotNull().WithMessage("Mesaj Sahibinin Mail Adresi Boş Geçilemez !");
            RuleFor(x=>x.MsgTitle).NotNull().WithMessage("Mesaj Başlığı Boş Geçilemez !");
            RuleFor(x=>x.MsgTitle).MaximumLength(50).MinimumLength(3).WithMessage("Mesaj Başlığı 3-50 karakter arası olmalıdır Geçilemez !");
            RuleFor(x=>x.MsgContent).NotNull().WithMessage("Mesaj İçeriği Boş Geçilemez !");
            RuleFor(x=>x.MsgContent).MinimumLength(5).WithMessage("Mesaj İçeriği Minimum 5 Karakter İçermelidir !");
        }
    }
}
