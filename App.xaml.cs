using System;
using System.Windows;
using System.Windows.Threading;

namespace BackgroundClicker.Wpf
{
    public partial class App : Application
    {
        public App()
        {
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), "Application Error", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
            Environment.Exit(1);
        }
    }
}
