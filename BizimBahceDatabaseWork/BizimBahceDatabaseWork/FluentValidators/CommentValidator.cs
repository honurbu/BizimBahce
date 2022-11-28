using BizimBahceDatabaseWork.Models.Entities;
using FluentValidation;

namespace BizimBahceDatabaseWork.FluentValidators
{
    public class CommentValidator:AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.CommentTitle).NotNull().WithMessage("Yorum Başlığı Boş Geçilemez !");
            RuleFor(x => x.CommentSubject).NotNull().WithMessage("Yorum İçeriği Boş Geçilemez !");
        }
    }
}
