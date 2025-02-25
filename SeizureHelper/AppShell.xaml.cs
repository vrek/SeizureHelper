namespace SeizureHelper
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MedicationDetail), typeof(MedicationDetail));
            Routing.RegisterRoute(nameof(MedicationView), typeof(MedicationView));
        }
    }
}
