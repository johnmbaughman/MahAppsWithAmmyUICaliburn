using System;
using System.Windows;

namespace MahAppsWithAmmyUICaliburnNoMEF.Controls
{
    public class ThemeManager : IThemeManager
    {
        private readonly ResourceDictionary themeResources;

        public ThemeManager()
        {
            themeResources = new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/MahAppsWithAmmyUICaliburnNoMEF;component/Resources/Theme1.g.xaml")
            };
        }

        public ResourceDictionary GetThemeResources()
        {
            return themeResources;
        }
    }
}