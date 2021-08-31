using System;
using Design.Patterns.Commands.Aula03.Entidades;
using Design.Patterns.Commands.Common;

namespace Design.Patterns.Commands.Aula03.Commands
{
    public class ContaBancariaCommand : ICommand
    {
        private readonly ContaBancaria _conta;
        private readonly Acao _acao;
        private readonly int _valor;
        
        public bool Sucesso { get; set; }

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
                    Sucesso = true;
                    break;
                case Acao.Sacar:
                    Sucesso = _conta.Sacar(_valor);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void DesfazerComando()
        {
            if (!Sucesso) return;
            switch (_acao)
            {
                case Acao.Depositar:
                    _conta.Sacar(_valor);
                    break;
                case Acao.Sacar:
                    _conta.Depositar(_valor);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}