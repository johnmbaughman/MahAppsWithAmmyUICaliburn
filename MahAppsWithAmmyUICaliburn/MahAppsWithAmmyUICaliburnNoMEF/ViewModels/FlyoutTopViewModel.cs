using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels
{
    public class FlyoutTopViewModel : FlyoutBaseViewModel
    {
        public FlyoutTopViewModel()
        {
            Header = "Top";
            Position = Position.Top;
            Theme = FlyoutTheme.Accent;
        }
    }
}