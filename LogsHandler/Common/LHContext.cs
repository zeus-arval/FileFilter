using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace LogsHandler.Common
{
    public class LHContext
    {
        public class CommandsMetadataContext
        {
            public string OPEN_FILE_TEXT { get; } = "OpenFileCommand";
            public string OPEN_RECENT_FILE_TEXT { get; } = "OpenRecentFileCommand";
            public string EXIT_TEXT { get; } = "ExitCommand";
            public string COPY_TEXT { get; } = "CopyCommand";
            public string OPEN_OPTIONS_TEXT { get; } = "OpenOptionsCommand";
            public string OPEN_HIGHLIGHTING_TEXT { get; } = "OpenHighlightingCommand";
            public string LOAD_CONFIGURATION_FROM_FILE_TEXT { get; } = "LoadConfigurationFromFileCommand";
            public string SAVE_CONFIGURATION_TO_FILE_TEXT { get; } = "SaveConfigurationToFileCommand";
            public string ABOUT_TEXT { get; } = "AboutFileFilterCommand";
        }
        public ServiceContext ServiceContext { get; }

        public CommandsMetadataContext CommandsContext { get; }

        public LHContext(ServiceContext serviceContext)
        {
            ServiceContext = serviceContext;
            CommandsContext = new CommandsMetadataContext();
        }
    }
}
