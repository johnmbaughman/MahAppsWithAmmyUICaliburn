using Caliburn.Micro;
using MahAppsWithAmmyUICaliburnNoMEF.ViewModels;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels
{
    public class ShellViewModel : Screen, IShell
    {
        public IObservableCollection<FlyoutBaseViewModel> FlyoutViewModels { get; }

        public ShellViewModel()
        {
            FlyoutViewModels = new BindableCollection<FlyoutBaseViewModel>();
        }

        public void Close()
        {
            TryClose();
        }

        public void ToggleFlyout(int index)
        {
            var flyout = FlyoutViewModels[index];
            flyout.IsOpen = !flyout.IsOpen;
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();
            DisplayName = "Caliburn Metro Demo";
            FlyoutViewModels.Add(new Flyout1ViewModel());
            FlyoutViewModels.Add(new Flyout2ViewModel());
            FlyoutViewModels.Add(new Flyout3ViewModel());
            FlyoutViewModels.Add(new FlyoutSettingsViewModel());
            FlyoutViewModels.Add(new FlyoutLeftViewModel());
            FlyoutViewModels.Add(new FlyoutTopViewModel());
            FlyoutViewModels.Add(new FlyoutBottomViewModel());
        }
    }
}