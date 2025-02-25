using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace SeizureHelper.ViewModels;
public partial class MainViewModel : ObservableObject

{
    [RelayCommand]
    async Task GoToMedicationView()
    {
        await Shell.Current.GoToAsync("MedicationView");
    }
}
