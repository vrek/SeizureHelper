using SeizureHelper.ViewModels;

namespace SeizureHelper;

public partial class MedicationDetail : ContentPage
{
    public MedicationDetail(MedicationDetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}