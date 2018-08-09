using System;
using System.Collections.Generic;
using System.Windows;
using Caliburn.Micro;
using MahAppsWithAmmyUICaliburnNoMEF.Controls;
using MahAppsWithAmmyUICaliburnNoMEF.ViewModels;
using ViewLocator = MahAppsWithAmmyUICaliburnNoMEF.Controls.ViewLocator;

namespace MahAppsWithAmmyUICaliburnNoMEF
{
    public class AppBootstrapper : BootstrapperBase
    {
        private SimpleContainer _container;

        public AppBootstrapper()
        {
            Initialize();
        }

        /// <summary>
        /// Override this to provide an IoC specific implementation.
        /// </summary>
        /// <param name="instance">The instance to perform injection on.</param>
        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        /// <summary>
        ///   This example uses the built in Caliburn SimpleContainer class.
        /// </summary>
        protected override void Configure()
        {
            _container = new SimpleContainer();

            _container.Singleton<IWindowManager, WindowManager>();
            _container.Singleton<IEventAggregator, EventAggregator>();
            _container.Singleton<IThemeManager, ThemeManager>();
            _container.Singleton<IViewLocator, ViewLocator>();
            _container.Singleton<StartupTasks>();
            _container.Singleton<IShell, ShellViewModel>();
        }

        /// <summary>
        /// Gets all instances.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <returns>IEnumerable&lt;System.Object&gt;.</returns>
        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return _container.GetAllInstances(serviceType);
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="serviceType">Type of the service.</param>
        /// <param name="key">The key.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="System.InvalidOperationException">Could not locate any instances.</exception>
        protected override object GetInstance(Type serviceType, string key)
        {
            return _container.GetInstance(serviceType, key) ?? throw new InvalidOperationException("Could not locate any instances.");
        }

        /// <summary>
        /// Override this to add custom behavior to execute after the application starts.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The args.</param>
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // Simple to find and do the same thing that the MEF
            var startupTasks = (StartupTasks)GetInstance(typeof(StartupTasks), null);
            startupTasks.ApplyBindingScopeOverride();
            startupTasks.ApplyViewLocatorOverride();

            DisplayRootViewFor<IShell>();
        }
    }
}