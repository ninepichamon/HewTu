namespace HewTU;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	private async void OnLoginButtonClicked(object sender, EventArgs e)
{
    
    await Navigation.PushAsync(new StorePage());
}

}