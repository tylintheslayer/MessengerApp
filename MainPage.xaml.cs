namespace MessengerApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            Routing.RegisterRoute("TextPage", typeof(TextPage));
        }

        
        private async void Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TextPage");
        }
    }

}
