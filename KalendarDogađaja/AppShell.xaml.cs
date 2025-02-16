namespace KalendarDogađaja
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DodajDogadajPage), typeof(DodajDogadajPage));
            Routing.RegisterRoute(nameof(PregledDogadajaPage), typeof(PregledDogadajaPage));
        }
    }
}
