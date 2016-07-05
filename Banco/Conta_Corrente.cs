using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
   public class Conta_Corrente : Conta
    {
        public Conta_Corrente(int numero_Conta, double dinheiro, Pessoa pessoa1) : base(numero_Conta, dinheiro, pessoa1)
        {
        }
    }
}
