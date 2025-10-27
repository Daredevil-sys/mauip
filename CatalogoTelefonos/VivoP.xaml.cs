namespace CatalogoTelefonos;

public partial class VivoP : ContentPage
{
	public VivoP()
	{
		InitializeComponent();
	}

    private async void Vivox200ultra(object sender, TappedEventArgs e)
=> await Navigation.PushAsync(new Vivox200ultra());

    private async void Vivox200pro(object sender, TappedEventArgs e)
   => await Navigation.PushAsync(new Vivox200pro());

    private async void Vivox200(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new Vivox200());

    private async void Vivox200fe(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new Vivox200fe());
}