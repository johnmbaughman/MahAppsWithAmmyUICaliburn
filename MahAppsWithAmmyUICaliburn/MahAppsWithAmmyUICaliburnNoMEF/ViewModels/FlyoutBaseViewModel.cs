using Caliburn.Micro;
using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels
{
    public abstract class FlyoutBaseViewModel : PropertyChangedBase
    {
        private string header;
        private bool isOpen;
        private Position position;
        private FlyoutTheme theme = FlyoutTheme.Dark;

        public string Header
        {
            get { return header; }
            set
            {
                if (value == header)
                {
                    return;
                }
                header = value;
                NotifyOfPropertyChange(() => Header);
            }
        }

        public bool IsOpen
        {
            get { return isOpen; }
            set
            {
                if (value.Equals(isOpen))
                {
                    return;
                }
                isOpen = value;
                NotifyOfPropertyChange(() => IsOpen);
            }
        }

        public Position Position
        {
            get { return position; }
            set
            {
                if (value == position)
                {
                    return;
                }
                position = value;
                NotifyOfPropertyChange(() => Position);
            }
        }

        public FlyoutTheme Theme
        {
            get { return theme; }
            set
            {
                if (value == theme)
                {
                    return;
                }
                theme = value;
                NotifyOfPropertyChange(() => Theme);
            }
        }
    }
}