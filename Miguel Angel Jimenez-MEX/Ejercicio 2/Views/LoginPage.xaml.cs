using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ejercicio2.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Title = "Login";
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            await DisplayAlert("Aviso", "Servicio no disponible", "Cerrar");
        }
    }
}
