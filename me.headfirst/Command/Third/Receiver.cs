using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.headfirst.Command.Third
{
    /// <summary>
    /// This is a class that performs the Action associated with the request.
    /// Esta es una clase que realiza la acción asociada con la solicitud.
    /// </summary>
    public class Receiver
    {
        public void Action(string message)
        {
            Console.WriteLine("Action called with message: {0}", message);
        }
    }
}
