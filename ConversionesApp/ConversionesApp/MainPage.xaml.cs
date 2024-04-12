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
            if (cantidad != null && !string.IsNullOrWhiteSpace(cantidad.Text))
            {
                float numero = float.Parse(cantidad.Text);

                peticion.PedirComunicacion("api/Conversiones/MetroCM?cantidad=" + numero, MetodoHTTP.GET, TipoContenido.JSON);
                string respuestaJson = peticion.ObtenerJson();
                DisplayAlert("Resultado", respuestaJson, "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa un valor", "OK");
            }
        }

        private void Centimetros_Clicked(object sender, EventArgs e)
        {
            if (cantidad != null && !string.IsNullOrWhiteSpace(cantidad.Text))
            {
                float numero = float.Parse(cantidad.Text);
                peticion.PedirComunicacion("api/Conversiones/CentimetrosM?cantidad=" + numero, MetodoHTTP.GET, TipoContenido.JSON);
                string respuestaJson = peticion.ObtenerJson();
                DisplayAlert("Resultado", respuestaJson, "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa un valor", "OK");
            }
        }

        private void MetrosP_Clicked(object sender, EventArgs e)
        {
            if (cantidad != null && !string.IsNullOrWhiteSpace(cantidad.Text))
            {
                float numero = float.Parse(cantidad.Text);
                peticion.PedirComunicacion("api/Conversiones/MetroP?cantidad=" + numero, MetodoHTTP.GET, TipoContenido.JSON);
                string respuestaJson = peticion.ObtenerJson();
                DisplayAlert("Resultado", respuestaJson, "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa un valor", "OK");
            }
        }

        private void CentimetrosP_Clicked(object sender, EventArgs e)
        {
            if (cantidad != null && !string.IsNullOrWhiteSpace(cantidad.Text))
            {
                float numero = float.Parse(cantidad.Text);
                peticion.PedirComunicacion("api/Conversiones/CentimetrosP?cantidad=" + numero, MetodoHTTP.GET, TipoContenido.JSON);
                string respuestaJson = peticion.ObtenerJson();
                DisplayAlert("Resultado", respuestaJson, "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa un valor", "OK");
            }
        }

        private void PulgadasCM_Clicked(object sender, EventArgs e)
        {
            if (cantidad != null && !string.IsNullOrWhiteSpace(cantidad.Text))
            {
                float numero = float.Parse(cantidad.Text);
                peticion.PedirComunicacion("api/Conversiones/PulgadaCM?cantidad=" + numero, MetodoHTTP.GET, TipoContenido.JSON);
                string respuestaJson = peticion.ObtenerJson();
                DisplayAlert("Resultado", respuestaJson, "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa un valor", "OK");
            }
        }

        private void PulgadasM_Clicked(object sender, EventArgs e)
        {
            if (cantidad != null && !string.IsNullOrWhiteSpace(cantidad.Text))
            {
                float numero = float.Parse(cantidad.Text);
                peticion.PedirComunicacion("api/Conversiones/PulgadaM?cantidad=" + numero, MetodoHTTP.GET, TipoContenido.JSON);
                string respuestaJson = peticion.ObtenerJson();
                DisplayAlert("Resultado", respuestaJson, "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa un valor", "OK");
            }
        }
    }
}
