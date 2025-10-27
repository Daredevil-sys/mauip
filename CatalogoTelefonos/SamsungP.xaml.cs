namespace CatalogoTelefonos;

public partial class SamsungP : ContentPage
{
	public SamsungP()
	{
		InitializeComponent();
	}

    private async void Samsungs25ultra(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new Samsungs25ultra());

    private async void samsungs25plus(object sender, TappedEventArgs e)
   => await Navigation.PushAsync(new Samsungs25plus());

    private async void samsungs25(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new Samsungs25());

    private async void samsungs25edge(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new Samsungs25edge());
}