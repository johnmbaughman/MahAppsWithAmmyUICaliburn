using System;
using System.Windows;

namespace MahAppsWithAmmyUICaliburn.Controls
{
    public interface IViewLocator
    {
        UIElement GetOrCreateViewType(Type viewType);
    }
}