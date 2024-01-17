namespace Proje;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Arama_Sayfası), typeof(Arama_Sayfası));
        Routing.RegisterRoute(nameof(Etkinlik_Sayfası), typeof(Etkinlik_Sayfası));
        Routing.RegisterRoute(nameof(Profile), typeof(Profile));
        Routing.RegisterRoute(nameof(Anasayfa), typeof(Anasayfa));
        Routing.RegisterRoute(nameof(Addstory), typeof(Addstory));
        Routing.RegisterRoute(nameof(Story), typeof(Story));
    }

}

