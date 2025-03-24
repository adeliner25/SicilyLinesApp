using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace SicilyLinesApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var restURL = "http://localhost:5169/Login?pseudo=" + pseudo.Text + "&pass=" + pass.Text;
            client.BaseAddress = new Uri(restURL);
            HttpResponseMessage response = await client.GetAsync(restURL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (Convert.ToBoolean(content))
                {
                    await Navigation.PushAsync(new UserPage());
                }
                else
                {
                    await DisplayAlert("Alerte", "Connexion user refusée", "Cancel");
                }
            }

            else
            {
                await DisplayAlert("Alerte", "Pas de connexion avec l'API", "Cancel");
            }
        }

        private async void OnSignupClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Info", "Redirection vers la page d'inscription.", "OK");
            // Navigation.PushAsync(new SignupPage()); // Active cette ligne si tu as une page d'inscription
        }
    }
}
