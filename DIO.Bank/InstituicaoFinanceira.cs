using System;
using System.Collections.Generic;
using TestCode;

namespace DIO.Bank
{
    class InstituicaoFinanceira
    {
        //atributos da classe, que no caso seria somente um a lista para armazenar as contas
        public static List<Conta> ContasInseridas { get; private set; }
        public InstituicaoFinanceira()
        {
            ContasInseridas = new List<Conta>();
        }

        public bool InserirContas(Conta contaInserida)
        {
            //adiciona a list, a conta criada
            ContasInseridas.Add(contaInserida);
            return true;
        }


        public List<Conta> ListarContas()
        {
            //percorre a list e exibe os atributos de cada classe
            foreach (var item in ContasInseridas)
            {
                item.ToString();
            }
            return ContasInseridas;
        }

        public bool RemoverContas(Conta contaRemovida)
        {
            //caso conta exista, faz exclusão
            if (ContasInseridas.Remove(contaRemovida))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public int GetNumeroDeContas()
        {
            //numero de contas atribuidas a instituição financeira
            return ContasInseridas.Count;
        }

        public bool Transferir(Conta contaRemetente, double valorTransferencia, Conta contaDestino)
        {
            //faz a validação e após isso, faz o deposito na conta destino
            if (contaRemetente.Sacar(valorTransferencia))
            {
                contaDestino.receberDeposito(valorTransferencia);
                Console.WriteLine("Transferência realizada com sucesso!");
                return true;
            }
            else
            {
                throw new ArgumentNullException("Lista vazia!");
                return false;
            }
        }
    }
}
