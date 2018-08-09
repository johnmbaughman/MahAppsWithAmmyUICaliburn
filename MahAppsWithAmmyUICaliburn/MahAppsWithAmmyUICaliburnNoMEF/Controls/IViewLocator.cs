using System;
using System.Windows;

namespace MahAppsWithAmmyUICaliburnNoMEF.Controls
{
    public interface IViewLocator
    {
        UIElement GetOrCreateViewType(Type viewType);
    }
}