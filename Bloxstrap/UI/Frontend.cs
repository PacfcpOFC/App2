using System.Windows;

using Bloxcrosoft.UI.Elements.Bootstrapper;
using Bloxcrosoft.UI.Elements.Dialogs;
using Bloxcrosoft.UI.Elements.Menu;

namespace Bloxcrosoft.UI
{
    static class Frontend
    {
        public static void ShowMenu() => new MainWindow().ShowDialog();

        public static MessageBoxResult ShowMessageBox(string message, MessageBoxImage icon = MessageBoxImage.None, MessageBoxButton buttons = MessageBoxButton.OK, MessageBoxResult defaultResult = MessageBoxResult.None)
        {
            if (App.LaunchSettings.IsQuiet)
                return defaultResult;

            switch (App.Settings.Prop.BootstrapperStyle)
            {
                case BootstrapperStyle.FluentDialog:
                case BootstrapperStyle.ByfronDialog:
                    return Application.Current.Dispatcher.Invoke(new Func<MessageBoxResult>(() =>
                    {
                        var messagebox = new FluentMessageBox(message, icon, buttons);
                        messagebox.ShowDialog();
                        return messagebox.Result;
                    }));

                default:
                    return System.Windows.MessageBox.Show(message, App.ProjectName, buttons, icon);
            }
        }

        public static void ShowExceptionDialog(Exception exception)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                new ExceptionDialog(exception).ShowDialog();
            });
        }

        public static void ShowConnectivityDialog(string targetName, string description, Exception exception)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                new ConnectivityDialog(targetName, description, exception).ShowDialog();
            });
        }

        public static IBootstrapperDialog GetBootstrapperDialog(BootstrapperStyle style)
        {
            return style switch
            {
                BootstrapperStyle.VistaDialog => new VistaDialog(),
                BootstrapperStyle.LegacyDialog2008 => new LegacyDialog2008(),
                BootstrapperStyle.LegacyDialog2011 => new LegacyDialog2011(),
                BootstrapperStyle.ProgressDialog => new ProgressDialog(),
                BootstrapperStyle.FluentDialog => new FluentDialog(),
                BootstrapperStyle.ByfronDialog => new ByfronDialog(),
                BootstrapperStyle.ProgressFluentDialog => new ProgressFluentDialog(false),
                BootstrapperStyle.ProgressFluentAeroDialog => new ProgressFluentDialog(true),
                _ => new FluentDialog()
            };
        }
    }
}
