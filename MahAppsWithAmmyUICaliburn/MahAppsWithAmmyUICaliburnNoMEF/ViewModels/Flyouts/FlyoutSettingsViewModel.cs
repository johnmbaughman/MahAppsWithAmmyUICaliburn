﻿using MahApps.Metro.Controls;

namespace MahAppsWithAmmyUICaliburnNoMEF.ViewModels.Flyouts
{
    public class FlyoutSettingsViewModel : FlyoutBaseViewModel
    {
        public FlyoutSettingsViewModel()
        {
            this.Header = "settings";
            this.Position = Position.Right;
        }
    }
}