namespace UEHtheTeam
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            chuyenlogin();
        }
        public async Task chuyenlogin()
        {
            await Task.Delay(1000);
            await Navigation.PushAsync(new Login());
        }

    }
}
