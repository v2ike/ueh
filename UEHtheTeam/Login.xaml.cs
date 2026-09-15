namespace UEHtheTeam;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text?.Trim();
        string password = PasswordEntry.Text;

        // 1. Kiểm tra không được để trống
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Thông báo", "Vui lòng nhập đầy đủ Email và Mật khẩu!", "OK");
            return;
        }

        // 2. Kiểm tra định dạng Email UEH (@st.ueh.edu.vn)
        if (!email.EndsWith("@st.ueh.edu.vn", StringComparison.OrdinalIgnoreCase))
        {
            await DisplayAlert("Đăng nhập thất bại", "Email không hợp lệ. Vui lòng sử dụng tài khoản email sinh viên UEH (@st.ueh.edu.vn)!", "OK");
            return;
        }

        // 3. Xử lý khi đăng nhập thành công (Đúng mail UEH)
        await DisplayAlert("Thành công", $"Đăng nhập thành công với tài khoản:\n{email}", "OK");
        await Navigation.PushAsync(new ChonMon());
        // Lưu email vào Application Properties để sử dụng ở các trang khác

        // TODO: Chuyển hướng sang trang HomePage (Trang chủ danh sách khóa học)
        // await Navigation.PushAsync(new HomePage());
    }

    private async void OnBackTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }
}