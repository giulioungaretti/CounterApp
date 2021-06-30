using BlankApp.Views;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using System;

using Windows.ApplicationModel;

namespace BlankApp
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        public static Window MainWindow { get; set; } = new Window() { Title = "AppDisplayName" };

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
            UnhandledException += App_UnhandledException;
            Suspending += suspendingEventHandler;
        }

        private void suspendingEventHandler(object sender, SuspendingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void App_UnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {

            if (MainWindow.Content == null)
            {
                MainWindow.Content = new Counter() ;
            }

            MainWindow.Activate();
        }

    }
}
