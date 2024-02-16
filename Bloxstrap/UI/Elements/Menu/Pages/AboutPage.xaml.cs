using Bloxcrosoft.UI.ViewModels.Menu;

namespace Bloxcrosoft.UI.Elements.Menu.Pages
{
    /// <summary>
    /// Interaction logic for AboutPage.xaml
    /// </summary>
    public partial class AboutPage
    {
        public AboutPage()
        {
            DataContext = new AboutViewModel();
            InitializeComponent();
        }
    }
}
