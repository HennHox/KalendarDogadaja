namespace KalendarDogađaja;

public partial class DodajDogadajPage : ContentPage
{
    private Entry nazivEntry;
    private Editor opisEditor;

    public DodajDogadajPage()
    {
        InitializeComponent();
        nazivEntry = this.FindByName<Entry>("NazivEntry");
        opisEditor = this.FindByName<Editor>("OpisEditor");
    }

    private async void OnSpremiClicked(object sender, EventArgs e)
    {
        string naziv = nazivEntry.Text;
        string opis = opisEditor.Text;

        if (string.IsNullOrWhiteSpace(naziv) || string.IsNullOrWhiteSpace(opis))
        {
            await DisplayAlert("Greška", "Molimo unesite naziv i opis događaja.", "OK");
            return;
        }
        App.Dogadaji.Add(new Dogadaj { Naziv = naziv, Opis = opis });

        await DisplayAlert("Uspjeh", "Događaj spremljen!", "OK");
        await Shell.Current.GoToAsync("..");
    }
}