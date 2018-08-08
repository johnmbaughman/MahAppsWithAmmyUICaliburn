using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburn.ViewModels.Flyouts
{
    public class FlyoutTopViewModel : FlyoutBaseViewModel
    {
        public FlyoutTopViewModel()
        {
            this.Header = "Top";
            this.Position = Position.Top;
            this.Theme = FlyoutTheme.Accent;
        }
    }
}