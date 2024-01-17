namespace Proje;

public partial class Arama_Sayfası : ContentPage
{
	public Arama_Sayfası()
	{
		InitializeComponent();
	}

    void Profil_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Profile));
    }

    void AramaSayfası_Clicked(System.Object sender, System.EventArgs e)
    {
        
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
