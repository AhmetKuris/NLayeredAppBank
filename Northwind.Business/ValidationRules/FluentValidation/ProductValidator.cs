using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<User>
    {       
        //FLUENT VALIDATION DOCUMENTATION FOR MORE
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            /////

            RuleFor(p => p.Name).Must(StartsWithA).WithMessage("User name should start with A");



        }


        //Custom validation example
        private bool StartsWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
