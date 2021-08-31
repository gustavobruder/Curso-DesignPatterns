namespace Design.Patterns.Commands.Aula03.Commands
{
    public interface ICommand
    {
        void ChamarComando();
        void DesfazerComando();
        bool Sucesso { get; set; }
    }
}