using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products;
public class CreateProductValidator : AbstractValidator<VM_Create_Product>
{
    public CreateProductValidator()
    {
        RuleFor(q => q.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Lutfen Ürün adı boş gecmeyiniz.")
            .MaximumLength(150)
            .MinimumLength(2)
            .WithMessage("Lutfen Ürün adını 2 ile 150 karakter arasında giriniz.");

        RuleFor(q => q.Stock)
            .NotEmpty()
            .NotNull()
            .WithMessage("Lutfen Ürün stok bilgisini boş gecmeyiniz.")
            .GreaterThanOrEqualTo(0)
            .WithMessage("Lutfen Ürün stok bilgisini 0 veya daha büyük bir değer olarak giriniz.");

        RuleFor(q => q.Price)
            .NotEmpty()
            .NotNull()
            .WithMessage("Lutfen Ürün fiyat bilgisini boş gecmeyiniz.")
            .GreaterThanOrEqualTo(0)
            .WithMessage("Lutfen Ürün fiyat bilgisini 0 veya daha büyük bir değer olarak giriniz.");
    }
}
