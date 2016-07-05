using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco;

namespace Teste_Banco
{
    [TestClass]
    public class Banco_Teste
    {
        [TestMethod]
        public void Sacando_Valores()
        {
            Pessoa nova_conta = new Pessoa();
            nova_conta.Nome = "Mateus Luiz Arruda de Souza Ramos";
            nova_conta.Numero_Conta = 120;
            nova_conta.CPF = "222.333.666-38";

            double saldo = 500;
            int numero = 1;


            Conta_Corrente conta_corrente = new Conta_Corrente(numero,saldo,nova_conta);
            conta_corrente.Sacar(100);

            Assert.AreEqual(400, conta_corrente.Saldo);
        }

        [TestMethod]
        public void Sacando_Valores_Com_Hack()
        {
            Pessoa nova_conta = new Pessoa();
            nova_conta.Nome = "Mateus Luiz Arruda de Souza Ramos";
            nova_conta.Numero_Conta = 120;
            nova_conta.CPF = "222.333.666-38";

            double saldo = 500;
            int numero = 1;


            Conta_Corrente conta_corrente = new Conta_Corrente(numero, saldo, nova_conta);
            conta_corrente.Sacar(1000000);

            Assert.AreEqual(500, conta_corrente.Saldo);
        }

        [TestMethod]
        public void Depositando_Valores_Irreais()
        {
            Pessoa nova_conta = new Pessoa();
            nova_conta.Nome = "Mateus Luiz Arruda de Souza Ramos";
            nova_conta.Numero_Conta = 120;
            nova_conta.CPF = "222.333.666-38";

            double saldo = 500;
            int numero = 1;


            Conta_Corrente conta_corrente = new Conta_Corrente(numero, saldo, nova_conta);
            conta_corrente.Depositar(-1000000);

            Assert.AreEqual(500, conta_corrente.Saldo);
        }

        [TestMethod]
        public void Depositando_no_Banco()
        {
            Pessoa nova_conta = new Pessoa();
            nova_conta.Nome = "Mateus Luiz Arruda de Souza Ramos";
            nova_conta.Numero_Conta = 120;
            nova_conta.CPF = "222.333.666-38";

            double saldo = 500;
            int numero = 1;


            Conta_Corrente conta_corrente = new Conta_Corrente(numero, saldo, nova_conta);
            conta_corrente.Depositar(2000);

            Assert.AreEqual(2500, conta_corrente.Saldo);
        }

        [TestMethod]
        public void Transferindo_Falha()
        {
            Pessoa nova_conta = new Pessoa();
            nova_conta.Nome = "Mateus Luiz Arruda de Souza Ramos";
            nova_conta.Numero_Conta = 120;
            nova_conta.CPF = "222.333.666-38";

            Pessoa nova_conta2 = new Pessoa();
            nova_conta2.Nome = "Diogo do Senai (Mestre Yoda)";
            nova_conta2.CPF = "111.444.777-38";
            nova_conta2.Numero_Conta = 7890;

            double saldo = 500;
            int numero = 1;

            Conta_Corrente conta_corrente = new Conta_Corrente(numero, saldo, nova_conta);
            conta_corrente.Transferir(nova_conta2,2000);

            Assert.AreEqual(500, conta_corrente.Saldo);
        }

        [TestMethod]
        public void Transferindo_Sucesso()
        {
            Pessoa nova_conta = new Pessoa();
            nova_conta.Nome = "Mateus Luiz Arruda de Souza Ramos";
            nova_conta.Numero_Conta = 120;
            nova_conta.CPF = "222.333.666-38";

            Pessoa nova_conta2 = new Pessoa();
            nova_conta2.Nome = "Diogo do Senai (Mestre Yoda)";
            nova_conta2.CPF = "111.444.777-38";
            nova_conta2.Numero_Conta = 7890;

            double saldo = 500;
            int numero = 1;

            Conta_Corrente conta_corrente = new Conta_Corrente(numero, saldo, nova_conta);
            conta_corrente.Transferir(nova_conta2, 100);

            Assert.AreEqual(400, conta_corrente.Saldo);
        }
    }
}
