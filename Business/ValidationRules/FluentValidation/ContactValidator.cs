﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.MobilePhone).NotEmpty().WithMessage("Lütfen muhatabın Ad, Soyad ve en az bir iletişim bilgisini giriniz.");
        }
    }
}
