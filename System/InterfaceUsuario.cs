using System;
using System.Collections.Generic;
using TestCode;

namespace DIO.Bank.System
{
    public class InterfaceUsuario
    {

        public string Senha { get; private set; }

        InstituicaoFinanceira Banco;
        Conta conta1;
        Conta conta2;

        public InterfaceUsuario(string senha)
        {
            Senha = senha;
            Banco = new InstituicaoFinanceira();
            //instancias de contas e atribuição de ambas na classe da instituição financeira
            conta1 = new Conta("Biel", TipoConta.PessoaFisica, 1000, 0);
            conta2 = new Conta("Biel1", TipoConta.PessoaJuridica, 0, 0);
            Banco.InserirContas(conta1);
            Banco.InserirContas(conta2);
        }

        public void UtilizarSistema(string senha_)
        {
            //Validação de senha, caso esteja correta, o acesso ao menu é permitido
            if (senha_.Equals(Senha))
            {
                MenuUsuario();
            }
            else
            {
                Console.WriteLine("Erro, senha incorreta!");
            }
        }

        private void MenuUsuario()
        {
            //looping para o usuario utilizar o sistema e acessar as opções
            string opcaoUsuario = null;

            Console.WriteLine("Login realizado com sucesso! ");

            while (opcaoUsuario != ("X"))
            {
                Console.WriteLine("Digite a opção: ");

                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("1: Listar contas cadastradas. ");

                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("2: Excluir conta.");

                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("3: Trasnferir conta. ");

                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("X");

                Console.WriteLine("");

                opcaoUsuario = Console.ReadLine();

                SelecionarEscolha(opcaoUsuario);
            }
        }
        private void SelecionarEscolha(string opcaoUsuario)
        {
            switch (opcaoUsuario)
            {
                //chama os métodos de acordo com as opções
                case "1":
                    Listar();
                    break;
                case "2":
                    List<Conta> conta = new List<Conta>();
                    conta.Add(conta2);
                    Excluir(conta);
                    break;
                case "3":
                    Trasnferir(conta1, 1000, conta2);
                    break;
                case "X":
                    break;
            }
        }
        private void Listar()
        {
            //listagem de contas na instituição
            Banco.ListarContas();
        }
        private void Excluir(List<Conta> contas)
        {
            //percorre todas as contas do banco e remove as passadas como parâmetro
            foreach (var item in contas)
            {
                Banco.RemoverContas(item);
            }
            Console.WriteLine("Contas excluidas com sucesso!");
        }
        private void Trasnferir(Conta conta1, double valor, Conta conta2)
        {
            //chama a funcão equivalente a transferência no objeto do banco
            Banco.Transferir(conta1, valor, conta2);
        }
    }
}
