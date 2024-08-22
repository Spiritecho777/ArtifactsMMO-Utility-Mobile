using Microsoft.Maui.Storage;

namespace ArtifactsMMO_Utility_Mobile.Page;

public partial class Key_Information : ContentPage
{
    public Key_Information()
    {
        InitializeComponent();

        string savedToken = Preferences.Get("Token",string.Empty);
        if (!string.IsNullOrEmpty(savedToken))
        {
            Info_Key.Text = savedToken;
        }
    }

    private async void Confirm_Click(object sender, EventArgs e)
    {
        Preferences.Set("Token",Info_Key.Text);

        await Navigation.PopAsync();
    }

    private async void Cancel_Click(object sender, EventArgs e) 
    {
        await Navigation.PopAsync();
    }
}