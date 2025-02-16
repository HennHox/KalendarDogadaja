namespace KalendarDogađaja;

public partial class PregledDogadajaPage : ContentPage
{
    private Dogadaj _dogadaj;

    public PregledDogadajaPage(Dogadaj dogadaj)
    {
        InitializeComponent();
        _dogadaj = dogadaj;

        // Popuni polja s postojećim podacima
        NazivEntry.Text = dogadaj.Naziv;
        OpisEditor.Text = dogadaj.Opis;
        DatumPicker.Date = dogadaj.Datum;
    }

    private async void OnSpremiClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NazivEntry.Text) || string.IsNullOrWhiteSpace(OpisEditor.Text))
        {
            await DisplayAlert("Greška", "Molimo popunite sva polja", "OK");
            return;
        }

        _dogadaj.Naziv = NazivEntry.Text;
        _dogadaj.Opis = OpisEditor.Text;
        _dogadaj.Datum = DatumPicker.Date;

        await DisplayAlert("Uspjeh", "Promjene su spremljene", "OK");
        await Shell.Current.GoToAsync("..");
    }

    private async void OnIzbrisiClicked(object sender, EventArgs e)
    {
        bool brisanje = await DisplayAlert("Potvrda",
            "Jeste li sigurni da želite izbrisati ovaj događaj?", "Da", "Ne");

        if (brisanje)
        {
            App.Dogadaji.Remove(_dogadaj);
            await Shell.Current.GoToAsync("..");
        }
    }
}