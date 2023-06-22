using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AYUGSIEXAMEN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        string Nombre;
        string Apellido;
        string Edad;
        string Fecha;
        string pkCiudad;
        string Pais;
        string Monto;
        string txtPago;
        string PagoTotal;
        public Resumen(string usuario, string Nombre, string Apellido,
        string Edad,
        string Fecha,
        string Ciudad,
        string Pais,
        string Monto,
        string Pago,
        string PagoTotal)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO " + usuario;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;    
            txtEdad.Text = Edad;
            txtFecha.Text = Fecha;  
           txtCiudad.Text = Ciudad;
            txtMontoInicial.Text = Monto;
            txtPagoMensual.Text = Pago;
            txtPagoTotal.Text = PagoTotal;  
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}