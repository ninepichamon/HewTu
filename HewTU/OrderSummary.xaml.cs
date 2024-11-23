namespace HewTU;

public partial class OrderSummary : ContentPage
{
	public OrderSummary()
	{
		InitializeComponent();
	}
	private async void NavigateToSuccessPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SuccessPage());
    }
}