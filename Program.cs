
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using taskManager_netcore.endpoints;
using taskManager_netcore.interfaces;
using taskManager_netcore.services;

namespace taskManager_netcore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IServiceProvider ServiceProvider { get; set; }
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConfigureServices();
            var mainForm = ServiceProvider.GetRequiredService<TaskForm>();
            Application.Run(mainForm);
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<ITask, TaskService>();
            services.AddSingleton<TaskForm, TaskForm>();
            services.AddTransient<TaskEndpoint, TaskEndpoint>();
            ServiceProvider = services.BuildServiceProvider();
            if (!EventLog.SourceExists("UPSTask"))
            {
                EventLog.CreateEventSource("UPSTask", "Application");
            }
        }
    }
}