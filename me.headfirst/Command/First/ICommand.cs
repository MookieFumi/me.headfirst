namespace me.headfirst.Command.First
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}