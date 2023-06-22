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
    public partial class Registro : ContentPage
    {
        string usuario;
        double costo = 1800;
        double residuo = 0;
        double cuota = 0;
        double interes = 0;
        double totalCuota = 0;
        double PagoTotal = 0;
        double valor = 0;


        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO CONECTADO " + usuario;
            this.usuario = usuario;
        }

        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double MontoInicial = Convert.ToDouble(txtMonto.Text);

                if (MontoInicial > 1800.00 || MontoInicial < 0)
                {
                    DisplayAlert("ERROR", " Valor fuera de rango ", "CERRAR");
                    
                }
               

            }
            catch (Exception)
            {
                DisplayAlert("ERROR", " ERROR AL EJECUTAR", "CERRAR");
            }

        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            double MontoInicial = Convert.ToDouble(txtMonto.Text);
                residuo = costo- MontoInicial;
                cuota = residuo/3;
                interes = costo * 0.05;
                totalCuota =  interes + cuota;
                valor = totalCuota * 3;
                PagoTotal = valor + MontoInicial;


                txtPago.Text = totalCuota.ToString("#.00");

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {


            Navigation.PushAsync(new Resumen(usuario,txtNombre.Text,
                txtApellido.Text,
                 Convert.ToString(txtEdad.Text),
                dpFecha.Date.ToString(),
                Convert.ToString(pkCiudad.Items[pkCiudad.SelectedIndex]),
                Convert.ToString(pkPais.Items[pkPais.SelectedIndex]),
                txtMonto.Text,
                txtPago.Text,
                Convert.ToString( this.PagoTotal)

                ));

        }
    }
}