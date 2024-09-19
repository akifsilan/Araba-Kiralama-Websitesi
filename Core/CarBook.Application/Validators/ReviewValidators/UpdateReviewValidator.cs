using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validators.ReviewValidators
{
    public class UpdateReviewValidator : AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz").MinimumLength(2).WithMessage("Müşteri adı en az 2 karakterli olmalıdır");
            RuleFor(x => x.RatingValue).NotEmpty().WithMessage("Lütfen puanlamayı boş geçmeyiniz");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Lütfen yorum kısmını doldurunuz").MinimumLength(50).WithMessage("En az 50 karakter girmelisiniz").MaximumLength(500).WithMessage("En fazla 500 karakter girebilirsiniz");
            RuleFor(x => x.ReviewDate).NotEmpty().WithMessage("Tarih alanını boş geçmeyiniz");
        }
    }
}
