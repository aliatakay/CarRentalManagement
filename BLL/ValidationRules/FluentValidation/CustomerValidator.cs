﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.UserId).NotNull();
            RuleFor(c => c.UserId).GreaterThan(0);

            RuleFor(c => c.CompanyName).NotEmpty();
            RuleFor(c => c.CompanyName).NotNull();
            RuleFor(c => c.CompanyName).MinimumLength(2);
            RuleFor(c => c.CompanyName).MaximumLength(200);
        }
    }
}