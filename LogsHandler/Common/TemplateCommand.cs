using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LogsHandler.Common
{
    public class TemplateCommand : ICommand
    {
        public string Name { get; }

        private readonly Action<object> _action;
        private readonly Func<bool> _canExecuteAction;
        private readonly bool _isAsync;

        public TemplateCommand(string name, Action<object> action, Func<bool> canExecuteAction, bool isAsync)
        {
            Name = name;

            _action = action;
            _canExecuteAction = canExecuteAction;
            _isAsync = isAsync;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteAction?.Invoke() ?? true;
        }

        public async void Execute(object parameter)
        {
            try
            {
                if (_isAsync)
                {
                    await Task.Run(() => _action(parameter)).ConfigureAwait(false);
                }
                else
                {
                    _action(parameter);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error, {0}", e.Message);
            }
        }

        public void ExecuteSync(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }

    public class CommandContent
    {
        public string Name { get; }
        public Action<object> Action { get; }
        public readonly Func<bool> CanExecuteAction;

        public CommandContent(string name, Action<object> action, Func<bool> canExecuteAction)
        {
            Name = name;
            Action = action;
            CanExecuteAction = canExecuteAction;
        }
    }
}
