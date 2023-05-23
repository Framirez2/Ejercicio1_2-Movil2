using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1View : ContentPage
    {
        public Page1View()
        {
            InitializeComponent();
        }

        private async void btn_enviar_info(object sender, EventArgs e)
        {
            string Nombre = nombre.Text;
            string Apellido = apellido.Text;
            string Edad = edad.Text;
            string Correo = correo.Text;
            await Navigation.PushAsync(new Page2View(Nombre, Apellido, Edad, Correo));
        }

       
    }
}