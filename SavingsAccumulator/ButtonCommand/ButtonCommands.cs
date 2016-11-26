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
            _action = action;//Binded to the change visibility property on main page view model
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();//when add button is pressed this method is activated
        }
    }
}
