using LogsHandler.Aids.Factory;
using LogsHandler.Common;
using System.Windows.Input;

namespace LogsHandler.MVVM
{
    public class RowButtonsViewModel
    {
        public ICommand OpenFileCommand { get; private set; }
        public ICommand OpenRecentFileCommand { get; private set; }
        public ICommand ExitCommand { get; private set; }
        public ICommand CopyCommand { get; private set; }
        public ICommand OpenOptionsCommand { get;  private set; }
        public ICommand OpenHighlightingCommand { get; private set; }
        public ICommand LoadConfigurationFromFileCommand { get; private set; }
        public ICommand SaveConfigurationToFileCommand { get; private set; }
        public ICommand AboutFileFilterCommand { get; private set; }

        public RowButtonsViewModel()
        {
        }
        
        public void InitializeCommands(params ICommand[] commands)
        {
            foreach (var command in commands)
            {
                if (command is TemplateCommand templateCommand)
                {
                    switch (templateCommand.Name)
                    {
                        case nameof(OpenFileCommand):
                            OpenFileCommand = command;
                            break;
                        case nameof(OpenRecentFileCommand):
                            OpenRecentFileCommand = command;
                            break;
                        case nameof(ExitCommand):
                            ExitCommand = command;
                            break;
                        case nameof(CopyCommand):
                            CopyCommand = command;
                            break;
                        case nameof(OpenOptionsCommand):
                            OpenOptionsCommand = command;
                            break;
                        case nameof(OpenHighlightingCommand):
                            OpenHighlightingCommand = command;
                            break;
                        case nameof(LoadConfigurationFromFileCommand):
                            LoadConfigurationFromFileCommand = command;
                            break;
                        case nameof(SaveConfigurationToFileCommand):
                            SaveConfigurationToFileCommand = command;
                            break;
                        case nameof(AboutFileFilterCommand):
                            AboutFileFilterCommand = command;
                            break;
                    }
                }
            }
        }
    }
}