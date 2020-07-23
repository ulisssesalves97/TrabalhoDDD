using FluentValidation;
using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Interfaces
{
    public interface IContaCorrenteService<T> where T : ContaCorrente
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
        
        T Saque<V>(T obj) where V: AbstractValidator<T>;

        T Credito<V>(T obj) where V: AbstractValidator<T>;
    }
}