using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace SeizureHelper.ViewModels;

public partial class MedicationViewModel : ObservableObject

{
    public MedicationViewModel()
    {
        text = string.Empty;
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;
        items.Add(Text);
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            _ = Items.Remove(s);
        }
    }

    [RelayCommand]
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync("MedicationDetail");
    }

}
