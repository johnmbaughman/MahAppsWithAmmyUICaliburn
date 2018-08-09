using MahApps.Metro.Controls;
using Caliburn.Micro;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels.Flyouts
{
    public class Flyout3ViewModel : FlyoutBaseViewModel
    {
        private readonly IObservableCollection<object> artists =
            new BindableCollection<object>();

        public IObservableCollection<object> Artists
        {
            get
            {
                return artists;
            }
        }

        public Flyout3ViewModel()
        {
            //SampleData.Seed();
            //this.Artists.AddRange(SampleData.Artists);
            Header = "third";
            Position = Position.Right;
        }
    }
}