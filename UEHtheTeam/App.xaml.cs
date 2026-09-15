namespace UEHtheTeam;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Gán trang Login làm trang khởi chạy chính
        MainPage = new NavigationPage(new Login());
    }
}