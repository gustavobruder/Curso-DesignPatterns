using System.Collections.Generic;
using System.Linq;

namespace Design.Patterns.Commands.Aula03.Commands
{
    public class CompositeContaBancariaCommand : List<ContaBancariaCommand>, ICommand
    {
        public CompositeContaBancariaCommand()
        {
        }

        public CompositeContaBancariaCommand(IEnumerable<ContaBancariaCommand> collection)
            : base(collection)
        {
        }

        public virtual void ChamarComando()
        {
            ForEach(comando => comando.ChamarComando());
        }

        public virtual void DesfazerComando()
        {
            foreach (var comando in ((IEnumerable<ContaBancariaCommand>) this).Reverse())
            {
                if (comando.Sucesso) comando.DesfazerComando();
            }
        }

        public virtual bool Sucesso
        {
            get { return this.All(comando => comando.Sucesso); }
            set
            {
                foreach (var comando in this)
                {
                    comando.Sucesso = value;
                }
            }
        }
    }
}