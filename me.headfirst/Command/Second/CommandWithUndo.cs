using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace me.headfirst.Command.Second
{
    public class CommandWithUndo
    {
        private readonly Action _execute;
        private readonly Action _undo;

        public CommandWithUndo(Action execute, Action undo)
        {
            _execute = execute;
            _undo = undo;
        }

        public void Execute()
        {
            _execute();
        }

        public void Undo()
        {
            _undo();
        }
    }
}
