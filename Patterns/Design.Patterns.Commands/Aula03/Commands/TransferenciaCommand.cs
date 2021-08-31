using Design.Patterns.Commands.Aula03.Entidades;
using Design.Patterns.Commands.Common;

namespace Design.Patterns.Commands.Aula03.Commands
{
    public class TransferenciaCommand : CompositeContaBancariaCommand
    {
        public TransferenciaCommand(ContaBancaria de, ContaBancaria para, int valor)
        {
            AddRange(new[]
            {
                new ContaBancariaCommand(de, Acao.Sacar, valor), 
                new ContaBancariaCommand(para, Acao.Depositar, valor), 
            });
        }

        public override void ChamarComando()
        {
            ContaBancariaCommand ultima = null;
            foreach (var comando in this)
            {
                if (ultima == null || ultima.Sucesso)
                {
                    comando.ChamarComando();
                    ultima = comando;
                }
                else
                {
                    comando.DesfazerComando();
                    break;
                }
            }
        }
    }
}