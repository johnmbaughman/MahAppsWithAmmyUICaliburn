using System;
using System.ComponentModel.Composition;
using System.Windows;

namespace MahAppsWithAmmyUICaliburn.Controls
{
    [Export(typeof(IThemeManager))]
    public class ThemeManager : IThemeManager
    {
        private readonly ResourceDictionary themeResources;

        public ThemeManager()
        {
            this.themeResources = new ResourceDictionary
                                      {
                                          Source = new Uri("pack://application:,,,/MahAppsWithAmmyUICaliburn;component/Resources/Theme1.g.xaml")
                                      };
        }

        public ResourceDictionary GetThemeResources()
        {
            return this.themeResources;
        }
    }
}