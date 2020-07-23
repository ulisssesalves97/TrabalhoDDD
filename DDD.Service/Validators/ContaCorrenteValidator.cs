using System;
using FluentValidation;
using DDD.Domain.Entities;

namespace DDD.Service.Validators
{
    public class ContaCorrenteValidator : AbstractValidator<ContaCorrente>
{
	public ContaCorrenteValidator()
        {
	    RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });
		
            RuleFor(c => c.Conta)
                .NotEmpty().WithMessage("É Necessário informar o Conta.")
                .NotNull().WithMessage("É Necessário informar o Conta.");
       
        }
			}
}