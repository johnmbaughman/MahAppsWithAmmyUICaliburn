using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels.Flyouts
{
    public class FlyoutBottomViewModel : FlyoutBaseViewModel
    {
        public FlyoutBottomViewModel()
        {
            this.Header = "Bottom";
            this.Position = Position.Bottom;
            this.Theme = FlyoutTheme.Light;
        }
    }
}