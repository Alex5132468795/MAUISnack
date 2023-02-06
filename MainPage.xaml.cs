namespace MauiApp18;
using CommunityToolkit;
using CommunityToolkit.Maui.Alerts;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	private void Button_Clicked(object sender, EventArgs e)
	{
		CancellationToken c = new CancellationToken();
		Snackbar snackbar = new Snackbar(); //{Text.color = Color.FromRgb(0, 255, 0) };
		snackbar = (Snackbar) Snackbar.Make("OWO", async () => await DisplayAlert("Welcom", "be-bei see you", "Okey"), "UWU", TimeSpan.FromSeconds(10));
		snackbar.Show();
	}
}

