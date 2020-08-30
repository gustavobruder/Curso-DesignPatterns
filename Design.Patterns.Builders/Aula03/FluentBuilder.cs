using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Builders.Aula03
{
    public class FluentBuilder
    {
        public static void Executar()
        {
            var builder = new HtmlBuilder("ul")
                .AdicionarFilho("li", "Hello")
                .AdicionarFilho("li", "World");
            Console.Write(builder.ToString());
        }
    }
}