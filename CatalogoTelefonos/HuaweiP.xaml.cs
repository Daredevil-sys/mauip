namespace CatalogoTelefonos;

public partial class HuaweiP : ContentPage
{
	public HuaweiP()
	{
		InitializeComponent();
	}

    private async void Huaweipura80ultra(object sender, TappedEventArgs e)
=> await Navigation.PushAsync(new HuaweiP80Ultra());

    private async void Huaweipura80pro(object sender, TappedEventArgs e)
   => await Navigation.PushAsync(new Huawei80pro());

    private async void Huaweipura80(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new Huawei80xaml());

    private async void Huaweipura70(object sender, TappedEventArgs e)
 => await Navigation.PushAsync(new Huaweip70());
}