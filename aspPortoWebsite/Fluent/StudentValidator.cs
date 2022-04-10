using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Fluent
{
    public class StudentValidator:AbstractValidator<StudentVm>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Fullname).NotEmpty().WithMessage("Bos qalmasin").MinimumLength(5).MaximumLength(30).WithMessage("Bos qalmasin");
            RuleFor(x => x.GroupId).NotNull();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
        }
    }
}
