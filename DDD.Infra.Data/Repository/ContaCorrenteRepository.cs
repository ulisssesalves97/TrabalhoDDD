using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDD.Infra.Data.Repository
{
     public class ContaCorrenteRepository<T> : IContaCorrenteRepository<T> where T : ContaCorrente
    {
        private SQLiteContext context = new SQLiteContext();

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int Conta)
        {
            context.Set<T>().Remove(Select(Conta));
            context.SaveChanges();
        }

        public void Saque(T Obj, decimal valor)
        {
            Obj.Debito(valor);
        }
        
           public void Credito(T obj, decimal valor)
        {
            obj.Credito(valor);
        }
        public IList<T> Select()
        {
            return context.Set<T>().ToList();
        }

        public T Select(int Conta)
        {
            return context.Set<T>().Find(Conta);
        }


    }
}