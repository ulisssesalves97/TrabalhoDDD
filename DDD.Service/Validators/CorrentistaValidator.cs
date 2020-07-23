using System;
using FluentValidation;
using DDD.Domain.Entities;

namespace DDD.Service.Validators
{
    public class CorrentistaValidator : AbstractValidator<Correntista>
{
	public CorrentistaValidator()
        {
	    RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Can't found the object.");
                });
		
            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("É Necessário informar o CPF.")
                .NotNull().WithMessage("É Necessário informar o CPF.");
       
        }
			}
}