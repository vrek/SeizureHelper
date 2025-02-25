using SeizureHelper.ViewModels;

namespace SeizureHelper;

public partial class MedicationView : ContentPage
{
    public MedicationView(MedicationViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
