using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ejercicio1
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            await DisplayAlert("Aviso", "Servicio no disponible", "Cerrar");
        }

    }
}
