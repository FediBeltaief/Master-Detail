using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Master_Detail
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterFlyoutPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
