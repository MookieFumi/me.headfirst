namespace me.headfirst.Command.Third
{
    /// <summary>
    /// Asks the command to carry out the action
    /// Pide el comando para llevar a cabo la acción
    /// </summary>
    public class Invoker
    {
        public ICommand Command { get; set; }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}