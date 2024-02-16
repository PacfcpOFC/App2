using System.Windows.Media;

namespace Bloxcrosoft.Models
{
    public class BootstrapperIconEntry
    {
        public BootstrapperIcon IconType { get; set; }
        public string Name => IconType.ToString();
        public ImageSource ImageSource => IconType.GetIcon().GetImageSource();
    }
}
