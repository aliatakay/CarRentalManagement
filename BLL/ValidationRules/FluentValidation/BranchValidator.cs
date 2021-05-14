﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ValidationRules.FluentValidation
{
    public class BranchValidator : AbstractValidator<Branch>
    {
        public BranchValidator()
        {
            RuleFor(b => b.CityId).NotEmpty();
            RuleFor(b => b.Address).MinimumLength(20);
            RuleFor(b => b.Address).MaximumLength(500);
        }
    }
}
