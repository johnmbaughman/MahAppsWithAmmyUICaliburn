﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Caliburn.Micro;

namespace MahAppsWithAmmyUICaliburnNoMEF.Controls
{
    public class ViewLocator : IViewLocator
    {
        private readonly IThemeManager themeManager;

        public ViewLocator(IThemeManager themeManager)
        {
            this.themeManager = themeManager;
        }

        public UIElement GetOrCreateViewType(Type viewType)
        {
            var cached = IoC.GetAllInstances(viewType).OfType<UIElement>().FirstOrDefault();
            if (cached != null)
            {
                Caliburn.Micro.ViewLocator.InitializeComponent(cached);
                return cached;
            }

            if (viewType.IsInterface || viewType.IsAbstract || !typeof(UIElement).IsAssignableFrom(viewType))
            {
                return new TextBlock { Text = string.Format("Cannot create {0}.", viewType.FullName) };
            }

            var newInstance = (UIElement)Activator.CreateInstance(viewType);

            var window = newInstance as Window;
            if (window != null)
            {
                window.Resources.MergedDictionaries.Add(themeManager.GetThemeResources());
            }

            Caliburn.Micro.ViewLocator.InitializeComponent(newInstance);
            return newInstance;
        }
    }
}