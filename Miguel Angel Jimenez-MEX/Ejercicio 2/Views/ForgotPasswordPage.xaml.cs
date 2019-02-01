using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ejercicio2.Views
{
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
            Title = "Recuperar contraseña";
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.lblRecuperar.IsVisible = false;
            this.txtRecuperar.IsVisible = false;

            this.lblCodigo.IsVisible = true;
            this.txtCodigo.IsVisible = true;
        }
    }
}
