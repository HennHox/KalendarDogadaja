namespace KalendarDogađaja
{
    public partial class App : Application
    {
        public static List<Dogadaj> Dogadaji { get; set; } = new List<Dogadaj>();
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
