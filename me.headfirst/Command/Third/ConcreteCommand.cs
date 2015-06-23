namespace me.headfirst.Command.Third
{
    /// <summary>
    /// This is a class that implements the Execute operation by invoking operation(s) on the Receiver.
    /// Esta es una clase que implementa la operación Ejecutar invocando la operación (s) en el receptor.
    /// </summary>
    public class ConcreteCommand : ICommand
    {
        protected readonly Receiver Receiver;
        public string Parameter { get; set; }

        public ConcreteCommand(Receiver receiver)
        {
            Receiver = receiver;
        }

        public void Execute()
        {
            Receiver.Action(Parameter);
        }
    }
}