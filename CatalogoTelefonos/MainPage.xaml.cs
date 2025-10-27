using Microsoft.Maui.Controls;
namespace CatalogoTelefonos
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();


        }


        //aqui estan las navegaciones

        private async void OnCelular1Tapped(object sender, TappedEventArgs e)
       => await Navigation.PushAsync(new Xiaomiprincipal());

        private async void OnCelular2Tapped(object sender, TappedEventArgs e)
        => await Navigation.PushAsync(new SamsungP());

        private async void OnCelular3Tapped(object sender, TappedEventArgs e)
            => await Navigation.PushAsync(new HuaweiP());

        private async void OnCelular4Tapped(object sender, TappedEventArgs e)
            => await Navigation.PushAsync(new VivoP());

        private async void OnCamaraTapped(object sender, TappedEventArgs e)
      => await Navigation.PushAsync(new Camaras());

        private async void OnCompletosTapped(object sender, TappedEventArgs e)
    => await Navigation.PushAsync(new Completos());







        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (CelularesGrid == null)
                return;

            // Modo celular
            if (width < 700)
            {
                if (CelularesGrid.ColumnDefinitions.Count != 1)
                {
                    CelularesGrid.RowDefinitions.Clear();
                    CelularesGrid.ColumnDefinitions.Clear();

                    CelularesGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                    // recalcula filas dinámicamente
                    int total = CelularesGrid.Children.Count;
                    CelularesGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                    for (int i = 1; i < total; i++)
                        CelularesGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                }
            }
            // Modo escritorio
            else
            {
                if (CelularesGrid.ColumnDefinitions.Count != 2)
                {
                    CelularesGrid.RowDefinitions.Clear();
                    CelularesGrid.ColumnDefinitions.Clear();

                    CelularesGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
                    CelularesGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                    // recalcula filas según cuántos elementos tengas
                    int total = CelularesGrid.Children.Count;
                    int filas = (int)Math.Ceiling(total / 2.0);

                    for (int i = 0; i < filas; i++)
                        CelularesGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                }
            }
        }

    }
}

