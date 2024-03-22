# Getting Started with the .NET MAUI SignaturePad 
A quick-start project that helps you integrate the Signature Pad control with the .NET MAUI application by adding the Syncfusion.Maui.SignaturePad package from NuGet.

Refer to the following documentation for the Syncfusion .NET MAUI SignaturePad Control: 
https://help.syncfusion.com/maui/signaturepad/getting-started

## Project prerequisites
Make sure that you have the compatible versions of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/ ) with the Dot NET MAUI workload and [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later version in your machine before starting to work on this project.

## How to run this application
To run this application, you need to first clone the `getting-started-with-the-dotnet-maui-signature-pad` repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.
1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

4. Set any one of the platform specific projects (iOS, Android or UWP) as a start-up project.
5. Clean and build the application.
6. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.

## Adding a .NET MAUI SignaturePad reference
Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI SignaturePad control to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.SignaturePad and then install it.

**Step 1**: Create a .NET MAUI application project in Visual Studio 2022.

**Step 2**: Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) Nuget to the project from [nuget.org](https://www.nuget.org/).

**Step 3**: In the MauiProgram.cs file, register the Syncfusion.Maui.Core handler as follows.

**C#**
```
using Syncfusion.Maui.Core.Hosting;
namespace SignaturePad;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });
        return builder.Build();
    }
}
```
## Customization in SignaturePad control
**Initialize signature pad**

**XAML**
```
<ContentPage
    . . .
    xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <Grid>
        <signaturePad:SfSignaturePad />
    </Grid>
</ContentPage>
```

**OUTPUT**

![image](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-signature-pad/assets/127498902/40b8d18b-754d-40d4-93ce-01a82c0f1d9b)

**Customize signature stroke color**

**XAML**
```
<signaturePad:SfSignaturePad StrokeColor="Red" />
```

**OUTPUT**

![image](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-signature-pad/assets/127498902/5ebe84db-c702-49fc-807c-06cfaa189386)

**Customize signature stroke thickness**

**XAML**
```
<signaturePad:SfSignaturePad MinimumStrokeThickness="1"
                             MaximumStrokeThickness="6" />
```

**OUTPUT**

![image](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-signature-pad/assets/127498902/19112838-03ed-46ca-a248-94301a14cb4e)



