using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburn.ViewModels.Flyouts
{
    public class FlyoutLeftViewModel : FlyoutBaseViewModel
    {
        public FlyoutLeftViewModel()
        {
            this.Header = "left";
            this.Position = Position.Left;
            this.Theme = FlyoutTheme.Accent;
        }
    }
}