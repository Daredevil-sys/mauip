namespace CatalogoTelefonos;

public partial class Xiaomiprincipal : ContentPage
{
	public Xiaomiprincipal()
	{
		InitializeComponent();
	}

    private async void OnXiaomi15UltraTapped(object sender, TappedEventArgs e)
    => await Navigation.PushAsync(new Xiaomiquinceultra());

    private async void OnXiaomi15ProTapped(object sender, TappedEventArgs e)
   => await Navigation.PushAsync(new Xiaomiquincepro());

    private async void OnXiaomi15Tapped(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new Xiaomiquince());

    private async void OnXiaomi15tproTapped(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new _15tpro());
}