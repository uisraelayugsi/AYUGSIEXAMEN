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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";
            if (txtUsuario.Text == usuario && txtContraseña.Text == contrasena)
            {
                Navigation.PushAsync(new Registro(usuario));

            }
            else
            {
                DisplayAlert("ERROR", "USUARIO Y CONTRASEÑA INCORRECTOS", "CERRAR");

            }
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}