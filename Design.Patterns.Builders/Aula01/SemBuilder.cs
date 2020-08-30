using System;
using System.Text;

namespace Design.Patterns.Builders.Aula01
{
    public class SemBuilder
    {
        public static void Executar()
        {
            var hello = "Hello";
            
            var builder = new StringBuilder();
            builder.Append("<p>");
            builder.Append(hello);
            builder.Append("</p>");
            
            Console.WriteLine(builder);
            builder.Clear();
            
            var palavras = new[] { "Hello", "World" };
            builder.Append("<ul>");
            foreach (var palavra in palavras)
            {
                builder.AppendFormat("<li>{0}</li>", palavra);
            }
            builder.Append("</ul>");
            Console.WriteLine(builder);
        }
    }
}