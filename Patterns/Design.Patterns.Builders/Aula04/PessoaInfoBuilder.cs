namespace Design.Patterns.Builders.Aula04
{
    public class PessoaInfoBuilder<T> : PessoaBuilder where T : PessoaInfoBuilder<T>
    {
        public T Chamada(string nome)
        {
            pessoa.Nome = nome;
            return (T) this;
        }
    }
}