using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    abstract public class Conta
    {
        public int Numero { get; protected set; }
        public double Saldo { get; protected set; }
        public Pessoa Titular { get; protected set; }

        public Conta(int numero_Conta, double dinheiro, Pessoa pessoa1)
        {
            Numero = numero_Conta;
            Saldo = dinheiro;
            Titular = pessoa1;
        } 

        public int Sacar(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
                return 32;
            }
            return 0;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Transferir(Pessoa destino, double valor)
        {
            if (Sacar(valor) == 32) ;
        }
    }
}
