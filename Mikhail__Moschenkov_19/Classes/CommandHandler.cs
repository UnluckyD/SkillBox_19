using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BankSystemApp
{
    class CommandHandler : ICommand
    {
        private Action _action;
        private Func<bool> _canExecute;
        public delegate void MouseAction(Button button);
        private MouseAction _mouseAction;
        private Button _button;

        public CommandHandler(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }
        public CommandHandler(MouseAction mouseAction, Func<bool> canExecute, Button button)
        {
            _mouseAction = mouseAction;
            _canExecute = canExecute;
            _button = button;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            if (_action != null)
                _action();
            if (_mouseAction != null && _button != null)
                _mouseAction(_button);
        }
    }
}
