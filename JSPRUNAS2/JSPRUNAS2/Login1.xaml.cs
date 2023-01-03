using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JSPRUNAS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login1 : ContentPage
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "jpruna";
            string contraseña = "12345";
            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                Navigation.PushAsync(new Login(usuario));
            }
            else
            {
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "CERRAR");
            }
        }
    }
}