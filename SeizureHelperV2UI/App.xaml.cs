using SeizureHelperV2UI.Pages;

namespace SeizureHelperV2UI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    readonly NavigationPage navigationPage = new(new Home())
    {
        BarBackgroundColor = Colors.DarkBlue,
        BarTextColor = Colors.Bisque
    };

    public App(NavigationPage navigationPage) => this.navigationPage = navigationPage;

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new NavigationPage());
    }
}

