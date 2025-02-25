using SeizureHelper.ViewModels;

namespace SeizureHelper;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
