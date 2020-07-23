using DDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces
{
    public interface IRepository<T> where T : Correntista
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> Select();
    }
}