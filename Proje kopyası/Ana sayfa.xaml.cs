namespace Proje;

public partial class Anasayfa : ContentPage
{
	public Anasayfa()
	{
		InitializeComponent();

        eventt.ItemsSource = GetEvents();
        
    }

    void EtkinlikSayfası_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Etkinlik_Sayfası));
    }

    void Profil_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Profile));
    }

    void AramaSayfası_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Arama_Sayfası));
    }

    void AddstoryButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Story));
    }



    private List<Events> GetEvents()
    {
        return new List<Events>
        {
            new Events {Name="Meksika", Location="Beşiktaş",Imageurl="https://www.fotoyucel.com//images/video/video.jpg"},

            new Events {Name="Meksika", Location="Beşiktaş",Imageurl="https://www.fotoyucel.com//images/video/video.jpg"},

            new Events {Name="Meksika", Location="Beşiktaş",Imageurl="https://www.fotoyucel.com//images/video/video.jpg"},

            new Events {Name="Meksika", Location="Beşiktaş",Imageurl="https://www.fotoyucel.com//images/video/video.jpg"},

            new Events {Name="Meksika", Location="Beşiktaş",Imageurl="https://www.fotoyucel.com//images/video/video.jpg"},

            new Events {Name="Meksika", Location="Beşiktaş",Imageurl="https://www.fotoyucel.com//images/video/video.jpg"},
        };
    }

    

}

