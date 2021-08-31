namespace Solid.Aberto.Fechado.Correto.Interfaces
{
    public interface IEspecificacao<T>
    {
        bool Comparar(T especificacao);
    }
}