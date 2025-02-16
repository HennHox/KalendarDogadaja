namespace KalendarDogađaja
{
    public partial class MainPage : ContentPage
    {
        private ListView dogadajiListView;

        public MainPage()
        {
            InitializeComponent();
            dogadajiListView = this.FindByName<ListView>("DogadajiListView");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            dogadajiListView.ItemsSource = null;  // Resetiraj prikaz
            dogadajiListView.ItemsSource = App.Dogadaji;
        }

        private async void OnDodajClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DodajDogadajPage));
        }

        private async void OnDogadajSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Dogadaj odabraniDogadaj)
            {
                await Navigation.PushAsync(new PregledDogadajaPage(odabraniDogadaj));
            }
            dogadajiListView.SelectedItem = null;
        }
    }
}