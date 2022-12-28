using LogsHandler.Aids.Factory;
using LogsHandler.Aids.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsHandler.Common
{
    public class ServiceContext
    {
        public AppOptions AppOptions { get; private set; }
        public MainFactory MainFactory { get; private set; }
        public FileReader FileReader { get; private set; }
        public FileHelper FileHelper { get; private set; }
        public FileContentLinesFilter FileContentLinesFilter { get; private set; }
        public IServiceProvider ServiceProvider { get; init; }

        public ServiceContext(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;

            CreateAppOptions();
            CreateFileContentLinesFilter();
            CreateMainFactory();
            CreateFileReader();
            CreateFileHelper();
        }

        private void CreateAppOptions()
        {
            AppOptions = ServiceProvider.GetRequiredService<AppOptions>();
        }

        private void CreateMainFactory()
        {
            MainFactory = ServiceProvider.GetRequiredService<MainFactory>();
        }

        private void CreateFileReader()
        {
            FileReader = ServiceProvider.GetRequiredService<FileReader>();
        }

        private void CreateFileHelper()
        {
            FileHelper = ServiceProvider.GetRequiredService<FileHelper>();
            FileHelper.OnFileChoosen += FileReader.ReadFile;
        }

        private void CreateFileContentLinesFilter()
        {
            FileContentLinesFilter = ServiceProvider.GetRequiredService<FileContentLinesFilter>();
        }
    }
}
