using System.Xml.Linq;

namespace ArtifactsMMO_Utility_Mobile.Page;

public partial class CharacterCreation : ContentPage
{
    public string Skin;
    public string playerName;
    public bool IsConfirmed { get; private set; }
    public CharacterCreation()
    {
        InitializeComponent();
        IsConfirmed = false;
    }

    private void ChangeSkin(object sender, EventArgs e)
    {
        if (SkinList.SelectedItem is string selectedItem)
        {
            string selectedSkin = selectedItem;
            string imagePath = string.Empty;

            switch (selectedSkin)
            {
                case "Men 1":
                    imagePath = "Resources/Skin/Images/men1.png";
                    Skin = "men1";
                    break;
                case "Men 2":
                    imagePath = "Resources/Images/men2.png";
                    Skin = "men2";
                    break;
                case "Men 3":
                    imagePath = "Resources/Images/men3.png";
                    Skin = "men3";
                    break;
                case "Women 1":
                    imagePath = "Resources/Images/women1.png";
                    Skin = "women1";
                    break;
                case "Women 2":
                    imagePath = "Resources/Images/women2.png";
                    Skin = "women2";
                    break;
                case "Women 3":
                    imagePath = "Resources/Images/women3.png";
                    Skin = "women3";
                    break;
                default:
                    imagePath = string.Empty;
                    Skin = string.Empty;
                    break;
            }

            if (!string.IsNullOrEmpty(imagePath))
            {
                SkinPicture.Source = ImageSource.FromFile(imagePath);
            }
            else
            {
                SkinPicture.Source = null;
            }
        }
    }

    private void Confirm_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(PlayerName.Text) || string.IsNullOrEmpty(Skin))
        {
            DisplayAlert("Validation Error", "Please provide all required information.", "OK");
            return;
        }
        else
        {
            playerName = PlayerName.Text;
            IsConfirmed = true;
            Navigation.PopAsync();
        }
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
        IsConfirmed = false;
        Navigation.PopAsync();
    }
}