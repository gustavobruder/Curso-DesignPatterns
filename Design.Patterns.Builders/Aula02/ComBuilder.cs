using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Builders.Aula02
{
    public class ComBuilder
    {
        public static void Executar()
        {
            var builder = new HtmlBuilder("ul");
            builder.AdicionarFilho("li", "Hello");
            builder.AdicionarFilho("li", "World");
            Console.Write(builder.ToString());
        }
    }
}