using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicacion2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void btnNosotros_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;
            await App.MAsterDet.Detail.Navigation.PushAsync(new Nosotros());

        }

        private async void btnProductos_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;
            await App.MAsterDet.Detail.Navigation.PushAsync(new Productos());


        }

        private async void btnUbicacion_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;
            await App.MAsterDet.Detail.Navigation.PushAsync(new Ubicacion());

        }

        private async void btnContactos_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;
            await App.MAsterDet.Detail.Navigation.PushAsync(new Contactos());

        }
    }
}