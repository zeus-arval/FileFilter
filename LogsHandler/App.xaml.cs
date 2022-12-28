using LogsHandler.Aids;
using LogsHandler.Aids.Factory;
using LogsHandler.Aids.Services;
using LogsHandler.Common;
using LogsHandler.MVVM;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using LHContext = LogsHandler.Common.LHContext;

namespace LogsHandler
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static LHContext Context => (Current as App)!.LHContext;
        public static IHost AppHost { get; private set; }
        public LHContext LHContext { get; private set; }
        public ServiceContext ServiceContext { get; private set; }
        
        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    ConfigureServices(services);
                })
                .Build();

            ServiceContext = new ServiceContext(AppHost.Services);
            LHContext = new LHContext(ServiceContext);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<FileHelper>();
            services.AddSingleton<FileReader>();
            services.AddSingleton<FileContentLinesFilter>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainFactory>();
            services.AddSingleton<AppOptions>();
            services.AddSingleton<LHContext>();
            services.AddSingleton<ServiceContext>();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();

            base.OnExit(e);
        }

        //private AppOptions InitializeGenericProperties()
        //{
        //    var options = new AppOptions();

        //    string optionsPath = "options.yml";

        //    if (File.Exists(optionsPath))
        //    {

        //    }
        //}
    }
}
