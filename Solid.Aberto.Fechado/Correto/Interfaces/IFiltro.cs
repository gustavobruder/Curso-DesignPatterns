using System.Collections.Generic;

namespace Solid.Aberto.Fechado.Correto.Interfaces
{
    public interface IFiltro<T>
    {
        IEnumerable<T> Filtrar(IEnumerable<T> itens, IEspecificacao<T> especificacao);
    }
}