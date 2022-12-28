using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {

        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage( "Yazar Adını Boş not includeGeçemezsiniz.");

            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Soyadı boş geçemezsin.");

            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");

            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Lütfen 20 karekterden fazla değer girişi yapmayın.");

            RuleFor(x => x.WriterAbout).MaximumLength(200).WithMessage("Hakkımda kısmını boş geçemezsiniz.");

            RuleFor(x => x.WriterAbout).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("Hakkında kısmında en az bir a harfi olmalıdır.");

            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçemezsiniz.");
        }
    }
}
