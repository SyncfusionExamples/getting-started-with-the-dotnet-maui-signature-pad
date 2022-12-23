namespace MauiProject;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("ORg4AjUWIQA/Gnt2VVhiQlFaclxJVHxIe0x0RWFbb1x6cVZMYFVBNQtUQF1hS35bd0NjX31XcX1QR2FY");
		InitializeComponent();

		MainPage = new AppShell();
	}
}
