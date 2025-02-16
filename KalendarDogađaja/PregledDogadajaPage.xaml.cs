namespace KalendarDogađaja;

public partial class PregledDogadajaPage : ContentPage
{
	public PregledDogadajaPage()
	{
		InitializeComponent();
	}
    private async void OnUrediClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Uredi", "Ovdje bi išla logika za uređivanje događaja.", "OK");
    }

    private async void OnObrisiClicked(object sender, EventArgs e)
    {
        bool potvrda = await DisplayAlert("Brisanje", "Jeste li sigurni da želite obrisati događaj?", "Da", "Ne");
        if (potvrda)
        {
            await DisplayAlert("Obrisano", "Događaj je obrisan.", "OK");
            await Shell.Current.GoToAsync("..");
        }
    }
}