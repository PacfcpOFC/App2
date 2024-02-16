using Bloxcrosoft.UI.ViewModels.Menu;

namespace Bloxcrosoft.UI.Elements.Menu.Pages
{
    /// <summary>
    /// Interaction logic for PreInstallPage.xaml
    /// </summary>
    public partial class PreInstallPage
    {
        public PreInstallPage()
        {
            DataContext = new PreInstallViewModel();
            InitializeComponent();
        }
    }
}
