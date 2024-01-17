namespace Proje;

public partial class Profile : ContentPage
{
	public Profile()
	{

        InitializeComponent();
        
        
	}

    

    void AramaSayfası_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Arama_Sayfası));
    }

    void EtkinlikSayfası_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Etkinlik_Sayfası));
    }

    void AnaSayfa_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(MainPage));
    }

    void PlusButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Story));
    }
}
