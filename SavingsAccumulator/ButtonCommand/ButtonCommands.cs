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
        Action<object> _action;

        public ButtonCommands(Action<object> action) {
            _action = action;//Binded to the change visibility property on main page view model
        }

        public bool CanExecute(object parameter)
        {
            return true;//return true so button is always active
        }

        public void Execute(object parameter)
        {
            _action(parameter);//when add button is pressed this method is activated
        }
    }
}
