﻿namespace Design.Patterns.Builders.Aula02
{
    public class HtmlBuilder
    {
        private readonly string _nome;
        ElementoHtml _elemento = new ElementoHtml();

        public HtmlBuilder(string nome)
        {
            _nome = nome;
            _elemento.Nome = nome;
        }

        public void AdicionarFilho(string nomeFilho, string textoFilho)
        {
            var filho = new ElementoHtml(nomeFilho, textoFilho);
            _elemento.Elementos.Add(filho);
        }

        public override string ToString()
        {
            return _elemento.ToString();
        }
    }
}