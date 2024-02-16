using System.Windows;
using System.Windows.Controls;

using Bloxcrosoft.Integrations;
using Bloxcrosoft.UI.ViewModels.ContextMenu;

namespace Bloxcrosoft.UI.Elements.ContextMenu
{
    /// <summary>
    /// Interaction logic for LogTracer.xaml
    /// </summary>
    public partial class LogTracer
    {
        private bool _autoscroll = true;

        public LogTracer(ActivityWatcher activityWatcher)
        {
            DataContext = new LogTracerViewModel(this, activityWatcher);
            InitializeComponent();
        }

        private void KeepOnTopMenuItem_Click(object sender, RoutedEventArgs e) => Topmost = ((MenuItem)sender).IsChecked;
        
        private void AutoScrollMenuItem_Click(object sender, RoutedEventArgs e) => _autoscroll = ((MenuItem)sender).IsChecked;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_autoscroll)
                ScrollViewer.ScrollToEnd();
        }
    }
}
