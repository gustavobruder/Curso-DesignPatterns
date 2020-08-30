using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Builders.Aula03
{
    public class ElementoHtml
    {
        public string Nome { get; set; }
        public string Texto { get; set; }
        public List<ElementoHtml> Elementos = new List<ElementoHtml>();

        private const int TamanhoIndentacao = 2;

        public ElementoHtml()
        {
        }

        public ElementoHtml(string nome, string texto)
        {
            Nome = nome;
            Texto = texto;
        }

        private string ToStringImpl(int indentacao)
        {
            var builder = new StringBuilder();
            var i = new string(' ', TamanhoIndentacao * indentacao);
            builder.AppendLine($"{i}<{Nome}>");

            if (!string.IsNullOrWhiteSpace(Texto))
            {
                builder.Append(new string(' ', TamanhoIndentacao * (indentacao + 1)));
                builder.AppendLine(Texto);
            }

            foreach (var elemento in Elementos)
            {
                builder.Append(elemento.ToStringImpl(indentacao + 1));
            }

            builder.AppendLine($"{i}</{Nome}>");
            return builder.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}