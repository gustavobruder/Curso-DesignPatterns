namespace Design.Patterns.Builders.Aula04
{
    public class PessoaTrabalhoBuilder<T> : PessoaInfoBuilder<PessoaTrabalhoBuilder<T>> where T : PessoaTrabalhoBuilder<T>
    {
        public T TrabalhaComo(string trabalho)
        {
            pessoa.Trabalho = trabalho;
            return (T) this;
        }
    }
}