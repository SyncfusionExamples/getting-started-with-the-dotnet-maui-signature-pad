namespace MauiProject;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    public void ClearSign(object? sender, EventArgs e)
    {
        signaturePad.Clear();
    }
}

