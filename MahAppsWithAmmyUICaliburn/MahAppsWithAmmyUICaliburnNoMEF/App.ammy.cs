using System;
using System.Windows;
using AmmySidekick;

namespace MahAppsWithAmmyUICaliburnNoMEF
{
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            App app = new App();
            app.InitializeComponent();

            RuntimeUpdateHandler.Register(app, "/" + Ammy.GetAssemblyName(app) + ";component/App.g.xaml");
            app.Run();
        }
    }
}