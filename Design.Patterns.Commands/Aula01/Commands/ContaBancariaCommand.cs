using System;
using Design.Patterns.Commands.Aula01.Entidades;
using Design.Patterns.Commands.Common;

namespace Design.Patterns.Commands.Aula01.Commands
{
    public class ContaBancariaCommand : ICommand
    {
        private ContaBancaria _conta;
        private Acao _acao;
        private int _valor;
        private bool _sucesso;

        public ContaBancariaCommand(ContaBancaria conta, Acao acao, int valor)
        {
            _conta = conta;
            _acao = acao;
            _valor = valor;
        }

        public void ChamarComando()
        {
            switch (_acao)
            {
                case Acao.Depositar:
                    _conta.Depositar(_valor);
                    break;
                case Acao.Sacar:
                    _conta.Sacar(_valor);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}