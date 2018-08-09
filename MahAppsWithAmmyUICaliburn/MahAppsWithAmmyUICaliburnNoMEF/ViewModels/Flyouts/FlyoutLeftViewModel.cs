using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels.Flyouts
{
    public class FlyoutLeftViewModel : FlyoutBaseViewModel
    {
        public FlyoutLeftViewModel()
        {
            Header = "left";
            Position = Position.Left;
            Theme = FlyoutTheme.Accent;
        }
    }
}