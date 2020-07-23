using System;

namespace DDD.Domain.Entities
{
     public abstract class Correntista 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
         public string Telefone { get; set; }
         public string Endereco { get; set; }
       
    }
}