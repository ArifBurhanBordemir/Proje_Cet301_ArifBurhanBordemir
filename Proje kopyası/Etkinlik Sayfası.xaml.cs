

namespace Proje;

public partial class Etkinlik_Sayfası : ContentPage
{
    private readonly DbService _dbService;
    public Etkinlik_Sayfası(DbService dbService)
	{
		InitializeComponent();
        
        _dbService = dbService;
        Task.Run(async () => eventt.ItemsSource = await _dbService.GetEvents());
    }

    void AnaSayfa_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(MainPage));
    }

    void EtkinlikSayfası_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    void AramaSayfası_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Arama_Sayfası));
    }

    void Profil_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Profile));
    }
    void PlusButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Story));
    }

    
}
