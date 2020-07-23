using System;

namespace DDD.Domain.Entities
{
    public class ContaCorrente : Correntista
    {
        public string Conta { get; set; }
        public decimal Saldo { get; set; }
        public decimal LimiteCredito { get; set; }
        
        public bool LimiteDebito(decimal valor)
        {
                return valor <= (LimiteCredito+Saldo);
        }
        public void Debito(decimal value){
            if(LimiteDebito(value) == true)
            {
                   this.Saldo = Saldo - value;
            }
            else {
                    throw new Exception("Você não possui saldo para essa alteração!");
            }
        }
            public void Credito(decimal value){
            if(value >= 50000)
            {
                this.Saldo = Saldo + value;
                throw new Exception("Esta Transação será notificada ao COAF, devido ao seu alto valor!");
            
            }
            else {
                   this.Saldo = Saldo + value;
            }
        }

    }
}