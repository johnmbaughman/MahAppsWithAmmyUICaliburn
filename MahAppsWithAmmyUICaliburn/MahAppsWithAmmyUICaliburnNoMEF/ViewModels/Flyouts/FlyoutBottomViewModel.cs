using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels.Flyouts
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