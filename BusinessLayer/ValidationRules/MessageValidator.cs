using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {

        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresini Boş Geçemezsin.");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsin.");

            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Geçemezsin.");

            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("En Az 5 karakter olmalı");

            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakteri geçmesin.");




        }



    }
}
