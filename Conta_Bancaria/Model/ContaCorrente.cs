using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria.Model
{
    public class ContaCorrente : Conta
    {
        
        private decimal limite;

        public ContaCorrente(int numero, int agencia, int tipo, string titular, decimal saldo, decimal limite) 
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }

        public decimal GetLimite()
        {
            return this.limite;
        }

        public void SetLimite(decimal limite)
        {
            this.limite = limite;
        }

        // Polimorfismo de Sobrescrita
        public override bool Sacar(decimal valor)
        {
            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }

            this.SetSaldo(this.GetSaldo() - valor);
            return true;

        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Limite da Conta: {this.limite}");
        }
    }
}
