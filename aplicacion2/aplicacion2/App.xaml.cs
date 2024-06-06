using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicacion2
{
    public partial class App : Application
    {
        public static MasterDetailPage MAsterDet {  get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
