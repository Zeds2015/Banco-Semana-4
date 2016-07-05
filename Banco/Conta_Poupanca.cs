using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
  public class Conta_Poupanca : Conta
    {
        public Conta_Poupanca(int numero_Conta, double dinheiro, Pessoa pessoa1) : base(numero_Conta, dinheiro, pessoa1)
        {
        }
    }
}
