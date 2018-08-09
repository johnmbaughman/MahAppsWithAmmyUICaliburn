using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels
{
    public class FlyoutBottomViewModel : FlyoutBaseViewModel
    {
        public FlyoutBottomViewModel()
        {
            Header = "Bottom";
            Position = Position.Bottom;
            Theme = FlyoutTheme.Light;
        }
    }
}