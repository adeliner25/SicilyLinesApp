namespace SicilyLinesApp;

public partial class EditProfilePage : ContentPage
{
    public EditProfilePage()
    {
        InitializeComponent();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Succès", "Profil mis à jour avec succès.", "OK");
    }
}
