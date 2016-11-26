using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SavingsAccumulator.ButtonCommand
{
    public class ButtonCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action _action;

        public ButtonCommands(Action action) {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
