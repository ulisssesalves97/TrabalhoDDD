using DDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces
{
    public interface IContaCorrenteRepository<T> where T : ContaCorrente
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);
        
        void Saque(T obj,decimal valor);

        void Credito(T obj, decimal valor);

        T Select(int id);

        IList<T> Select();
    }
}