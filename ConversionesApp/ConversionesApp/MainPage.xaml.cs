using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HTTPupt;
using Newtonsoft.Json;
namespace ConversionesApp
{
    public partial class MainPage : ContentPage
    {
        PeticionHTTP peticion = new PeticionHTTP("https://Cervantes.bsite.net/");
        public MainPage()
        {
            InitializeComponent();
        }
       
        private void Metros_Clicked(object sender, EventArgs e)
        {
            float numero = float.Parse(cantidad.Text);

            peticion.PedirComunicacion("api/Conversiones/Metro?cantidad=" + numero, MetodoHTTP.GET,TipoContenido.JSON);
            string respuestaJson = peticion.ObtenerJson();
            DisplayAlert("Resultado", respuestaJson, "Aceptar");

        }

        private void Centimetros_Clicked(object sender, EventArgs e)
        {
            float numero = float.Parse(cantidad.Text);
            peticion.PedirComunicacion("api/Conversiones/Centimetros?cantidad=" + numero, MetodoHTTP.GET, TipoContenido.JSON);
            string respuestaJson = peticion.ObtenerJson();
            DisplayAlert("Resultado", respuestaJson, "Aceptar");

        }

    }
}
