using LogsHandler.Aids;
using LogsHandler.Aids.Factory;
using LogsHandler.Aids.Services;
using LogsHandler.Common;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace LogsHandler.MVVM
{
    public class MainViewModel : NotifiableViewModel
    {
        private LHContext _lhContext;
        public MainFactory MainFactory { get; }
        public RowButtonsViewModel RowButtonsViewModel { get; set; }
        public FileContentViewModel FileContentViewModel { get; set; }
        
        public MainViewModel(LHContext lhContext, FileReader fileReader)
        {
            _lhContext = lhContext;
            MainFactory = new MainFactory();

            InitializeRowButtons(fileReader);
            InitializeFileContent(fileReader);
        }

        private void InitializeRowButtons(FileReader fileReader)
        {
            var commandsContext = _lhContext.CommandsContext;
            var commandContents = new List<CommandContent>()
            {
                new CommandContent(commandsContext.OPEN_FILE_TEXT, (o) => OpenFile(), () => true),
            };

            RowButtonsViewModel = MainFactory.CreateRowButtons(commandContents);
        }

        private void OpenFile()
        {
            _lhContext.ServiceContext.FileHelper.OpenFileDialog();
        }

        private void InitializeFileContent(FileReader fileReader)
        {
            FileContentViewModel = MainFactory.CreateFileContentViewModel(fileReader);
        }
    }
}
