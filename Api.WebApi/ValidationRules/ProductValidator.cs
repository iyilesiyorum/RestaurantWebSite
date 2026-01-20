using FluentValidation;
using Api.WebApi.Entities;

namespace Api.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını doldurun.");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapın.");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapın.");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez.").GreaterThan(0).WithMessage("Ürün fiyatı sıfırdan küçük olamaz.").LessThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz, değeri kontrol edin.");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez.");
        }
    }
}
