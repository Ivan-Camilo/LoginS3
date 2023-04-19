using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginS3
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }

        void Login_Clicked(System.Object sender, System.EventArgs e)
        {
            if (txtUsuario.Text == "estudiante2023" && txtClave.Text == "uisrael2023")
            {
                string usuario = txtUsuario.Text;
                Navigation.PushAsync(new CalculoNotas(usuario));
                txtUsuario.Text = "";
                txtClave.Text = "";
            }
            else
            {
                DisplayAlert("Error", "\nUsuario o Contraseña Incorrecta", "OK");
            }
        }
    }
}

