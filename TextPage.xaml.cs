namespace MessengerApp;

public partial class TextPage : ContentPage
{
	public TextPage()
	{
		InitializeComponent();
        Routing.RegisterRoute("Chats", typeof(NewChats));
    }

    private async void CounterBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Chats");

    }
}