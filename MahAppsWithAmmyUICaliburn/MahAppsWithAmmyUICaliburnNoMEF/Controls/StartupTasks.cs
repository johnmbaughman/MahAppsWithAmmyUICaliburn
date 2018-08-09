using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using Caliburn.Micro;
using MahApps.Metro.Controls;
using MahAppsWithAmmyUICaliburnNoMEF.Services;

namespace MahAppsWithAmmyUICaliburnNoMEF.Controls
{
    public delegate void StartupTask();

    public class StartupTasks
    {
        private readonly IViewLocator _viewLocator;
        //private readonly IServiceLocator serviceLocator;

        //public StartupTasks(IServiceLocator serviceLocator)
        //{
        //    this.serviceLocator = serviceLocator;
        //}

        public StartupTasks(IViewLocator viewLocator)
        {
            _viewLocator = viewLocator;
        }

        public void ApplyBindingScopeOverride()
        {
            var getNamedElements = BindingScope.GetNamedElements;
            BindingScope.GetNamedElements = o =>
                {
                    var metroWindow = o as MetroWindow;
                    if (metroWindow == null)
                    {
                        return getNamedElements(o);
                    }

                    var list = new List<FrameworkElement>(getNamedElements(o));
                    var type = o.GetType();
                    var fields =
                        o.GetType()
                         .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                         .Where(f => f.DeclaringType == type);
                    var flyouts =
                        fields.Where(f => f.FieldType == typeof(FlyoutsControl))
                              .Select(f => f.GetValue(o))
                              .Cast<FlyoutsControl>();
                    list.AddRange(flyouts);
                    return list;
                };
        }

        public void ApplyViewLocatorOverride()
        {
            //var viewLocator = this.serviceLocator.GetInstance<IViewLocator>();
            Caliburn.Micro.ViewLocator.GetOrCreateViewType = _viewLocator.GetOrCreateViewType;
        }
    }
}