using LogsHandler.Aids.Services;
using LogsHandler.Common;
using LogsHandler.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LogsHandler.Aids.Factory
{
    public class MainFactory
    {
        private CommandsFactory _commandsFactory;

        public MainFactory()
        {
            _commandsFactory = new CommandsFactory();
        }

        public RowButtonsViewModel CreateRowButtons(IEnumerable<CommandContent> commandContents)
        {
            RowButtonsViewModel rowButtonsViewModel = new();
            ICommand[] commands = commandContents.Select(x => _commandsFactory.CreateCommand(x.Name, x.Action, x.CanExecuteAction)).ToArray();
            rowButtonsViewModel.InitializeCommands(commands);

            return rowButtonsViewModel;
        }

        public FileContentViewModel CreateFileContentViewModel(FileReader fileReader)
        {
            return new FileContentViewModel(fileReader);
        }
    }
}
