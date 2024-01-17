namespace Proje;

public partial class Story : ContentPage
{
    private readonly DbService _dbService;
    private int _editEventId;

    public Story(DbService dbService)
    {
        InitializeComponent();

        _dbService = dbService;
        Task.Run(async () => ListView.ItemsSource = await _dbService.GetEvents());
    }


    private async void Savebuton_Clicked(System.Object sender, System.EventArgs e)
    {
        if (_editEventId == 0)
        {
            await _dbService.Create(new Events
            {
                Name = Name.Text,
                Location = Location.Text,
                Imageurl = Imageurl.Text
            });
        }
        else
        {
            await _dbService.Update(new Events
            {
                Id = _editEventId,
                Name = Name.Text,
                Location = Location.Text,
                Imageurl = Imageurl.Text
            });
            _editEventId = 0;
        }

        Name.Text = string.Empty;
        Location.Text = string.Empty;
        Imageurl.Text = string.Empty;

        ListView.ItemsSource = await _dbService.GetEvents();
        await Shell.Current.GoToAsync("..");
    }


    private async void ListView_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        var eventItem = (Events)e.Item;
        var action = await Shell.Current.DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");

        switch (action)
        {
            case "Edit":
                _editEventId = eventItem.Id;
                Name.Text = eventItem.Name;
                Location.Text = eventItem.Location;
                Imageurl.Text = eventItem.Imageurl;
                break;
            case "Delete":
                await _dbService.Delete(eventItem);
                ListView.ItemsSource = await _dbService.GetEvents();
                break;
        }
    }

    private async void Delete_Clicked(System.Object sender, System.EventArgs e)
    {
        if (ListView.SelectedItem is Events selectedEvent)
        {
            // Silme işlemini gerçekleştir
            await _dbService.Delete(selectedEvent);

            // Veritabanındaki güncel verileri al ve ListView'a ata
            ListView.ItemsSource = await _dbService.GetEvents();
        }
        else
        {
            // Kullanıcı bir öğe seçmediyse uyarı verebilirsiniz
            await DisplayAlert("Uyarı", "Lütfen bir öğe seçin", "Tamam");
        }
    }



}
    