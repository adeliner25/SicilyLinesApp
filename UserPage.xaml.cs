namespace SicilyLinesApp;

public partial class UserPage : ContentPage
{
    public UserPage()
    {
        InitializeComponent();
    }

    private void OnEditProfileClicked(object sender, EventArgs e)
    {
        // Navigation vers la page de modification des coordonnées
        Application.Current.MainPage = new EditProfilePage();
    }

    private void OnViewReservationsClicked(object sender, EventArgs e)
    {
        // Navigation vers la page des réservations
        Application.Current.MainPage = new ReservationsPage();
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        // Retour à la page de connexion
        Application.Current.MainPage = new LoginPage();
    }
}
