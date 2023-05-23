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
    public partial class Page2View : ContentPage
    {
        public Page2View(string Nombre, string Apellido, string Edad ,string Correo)
        {
            InitializeComponent();
            LabelBienvenida.Text = "Bienvenid@ " + Nombre + " " + Apellido + " " + "Edad: " + Edad + " " + "Correo: " + Correo;

        }
    }
}