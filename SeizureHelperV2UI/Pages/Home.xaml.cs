namespace SeizureHelperV2UI.Pages;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }

    private async void Medication_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MedicationView());
    }

    private void EditMedication_Clicked(object sender, EventArgs e)
    {

    }

    private void ReportSeizure_Clicked(object sender, EventArgs e)
    {

    }

    private void Login_Clicked(object sender, EventArgs e)
    {

    }

    private void Settings_Clicked(object sender, EventArgs e)
    {

    }
}