using System.Collections.Generic;
using Solid.Aberto.Fechado.Common;
using Solid.Aberto.Fechado.Correto.Interfaces;

namespace Solid.Aberto.Fechado.Correto.Implementacoes
{
    public class Filtro : IFiltro<Produto>
    {
        public IEnumerable<Produto> Filtrar(IEnumerable<Produto> itens, IEspecificacao<Produto> especificacao)
        {
            foreach (var item in itens)
            {
                if (especificacao.Comparar(item))
                {
                    yield return item;
                }
            }
        }
    }
}