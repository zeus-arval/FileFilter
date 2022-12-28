using LogsHandler.Common;
using System;
using System.Windows.Input;

namespace LogsHandler.Aids.Factory
{
    internal class CommandsFactory
    {
        public ICommand CreateCommand(string commandName, Action<object> action, Func<bool> canExecute)
        {
            return new TemplateCommand(commandName, action, canExecute, false);
        }
    }
}
