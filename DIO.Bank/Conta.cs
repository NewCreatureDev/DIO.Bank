using System;
using System.Collections.Generic;

namespace TestCode
{
    class Conta
    {
        //Atributos da classe que definem a conta
        public static int NumeroDeContas { get; private set; }
        public string Nome { get; private set; }
        public TipoConta Tipo { get; private set; }
        public double Saldo { get; private set; }
        public double Credito { get; private set; }

        //Construtor
        public Conta(string nome, TipoConta tipo, double saldo, double credito)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Saldo = saldo;
            this.Credito = credito;
            //Contabiliza o número de contas instanciadas
            NumeroDeContas++;
        }
        public bool Sacar(double valorSaque)
        {
            //valida se o saldo é suficiente e conclui o procedimento
            if (valorSaque > Saldo)
            {
                return false;
            }
            else
            {
                Saldo -= valorSaque;
                return true;
            }
        }
        public void receberDeposito(double valorDeposito)
        {
            //recebe o deposito no valor passado como parâmetro
            Saldo += valorDeposito;
        }
        public override string ToString()
        {
            
            //Retorna em string os atributos
            string retorno = "";
            retorno += $"Titular: {Nome} | ";
            retorno += $"Tipo: {Tipo} | ";
            retorno += $"Saldo: {Saldo} | ";
            retorno += $"Credito: {Credito}";
            Console.WriteLine(retorno);
            return retorno;
        }
    }
}
