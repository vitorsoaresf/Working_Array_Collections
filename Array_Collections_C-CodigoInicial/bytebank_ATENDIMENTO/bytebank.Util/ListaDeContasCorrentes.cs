using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _itensCount = 0;
        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void AdicionarConta(ContaCorrente conta)
        {
            if (VerificaQuantidade())
            {
                Console.WriteLine($"Adicionando item na posição {_itensCount}");
                _itens[_itensCount] = conta;
                _itensCount++;
            }
            else
            {
                Console.WriteLine($"Não há espaço suficiente para a adicição desse novo elemento");
            }

        }

        private bool VerificaQuantidade()
        {
            if (_itensCount < _itens.Length)
            {
                return true;
            }
            return false;
        }

        public void MostrarContas()
        {
            foreach (var item in _itens)
            {
                Console.WriteLine($"Conta: {item}");
            }
        }

        public void MostraMaiorContaDaLista()
        {
            var contaComMaiorValor = new ContaCorrente(1,"1");
            contaComMaiorValor.Saldo = 0;



            foreach (ContaCorrente item in _itens)
            {
                if(item.Saldo > contaComMaiorValor.Saldo)
                {
                    contaComMaiorValor = item;
                }
            }
            Console.WriteLine($"Conta com maior valor: {contaComMaiorValor}");

        }
    }
}
