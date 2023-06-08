using EticaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Name Not Null")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Please, min 5 max 150");
            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Lütfen Stock bilgisini boş geçmeyiniz.")
                .Must(s => s >= 0)
                    .WithMessage("Stok bilgisi 0 dan büyük olmalıdır. ");
            RuleFor(p => p.Price)
               .NotEmpty()
               .NotNull()
                   .WithMessage("Lütfen Stock bilgisini boş geçmeyiniz.")
               .Must(s => s >= 0)
                   .WithMessage("Stok bilgisi 0 dan büyük olmalıdır. ");
        }
    }
}
