namespace Proje;

public partial class Addstory : ContentPage
{
    private readonly DbService _dbService;
    private int _editEventId;

    public Addstory(DbService dbService)
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
    }

    /*private async void ListView_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        var event = (Events) e.Item;
    var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");
        switch (action)
        {
        case"Edit":
             break;
        case "Delete":
            break;
        }
    }*/
}