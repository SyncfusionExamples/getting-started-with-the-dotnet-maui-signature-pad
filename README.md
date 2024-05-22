# Getting Started with the .NET MAUI SignaturePad 
The [.NET MAUI SignaturePad](https://www.syncfusion.com/maui-controls/maui-signaturepad?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples) is an interactive UI control that allows users to capture smooth and realistic signatures. A quick-start project that helps you integrate the Signature Pad control with the .NET MAUI application by adding the Syncfusion.Maui.SignaturePad package from NuGet.

## Project prerequisites
Make sure that you have the compatible versions of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) with the Dot NET MAUI workload and [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later version in your machine before starting to work on this project.

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

## Features and Benefits

### Customization
The appearance of the .NET Maui SignaturePad is highly customizable.

### Realistic, handwritten signature look and feel
The unique stroke rendering algorithm draws a signature based on the speed of the gesture drawing along with minimum and maximum stroke thicknesses, which gives a realistic handwritten look and feel to the signature.

### Save signatures as images
[Save the drawn signature as an image](https://help.syncfusion.com/maui/signaturepad/getting-started#saving-the-signature-as-an-image?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples). This converted image can be embedded in documents, PDFs, and anything else that supports using images to denote a signature.

### Events
[Events](https://help.syncfusion.com/maui/signaturepad/getting-started#events?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples) occur whenever you start and finish drawing in the SignaturePad.

## Related links
[Learn More about .NET MAUI SignaturePad](https://www.syncfusion.com/maui-controls/maui-signaturepad?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)

[Download Free Trial](https://www.syncfusion.com/downloads/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)

[Pricing](https://www.syncfusion.com/sales/teamlicense?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)

[Documentation](https://help.syncfusion.com/maui/signaturepad/getting-started?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)

[View Demos](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-signature-pad?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)

[Community Forums](https://www.syncfusion.com/forums/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)

[Suggest a feature or report a bug](https://www.syncfusion.com/feedback/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)

[Online example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SignaturePad/SampleBrowser.Maui.SignaturePad?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)

## About Syncfusion .NET MAUI Controls

Syncfusion's [.NET MAUI UI Controls](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples) library is the only suite that you will ever need to build an application since it contains over 40 high-performance, lightweight, modular, and responsive UI Controls in a single package. In addition to SignaturePad, we provide popular .NET MAUI Controls such as [DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)[Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [Scheduler](https://www.syncfusion.com/maui-controls/maui-scheduler?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [ListView](https://www.syncfusion.com/maui-controls/maui-listview?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), and [Excel Library](https://www.syncfusion.com/document-processing/excel-framework/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples).

### About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 29,000 customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.

Today, we provide 1800+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [Angular](https://www.syncfusion.com/angular-components?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [React](https://www.syncfusion.com/react-components?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [Vue](https://www.syncfusion.com/vue-components?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [WPF](https://www.syncfusion.com/wpf-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples),[UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

<hr style="height:0.3px;border:none;color:lightgrey;background-color:lightgrey;" />

<p align="center">
<a href="mailto:sales@syncfusion.com?Subject=Syncfusion .NET MAUI SignaturePad - GitHub" target="_top">sales@syncfusion.com</a> | <a href="https://www.syncfusion.com?utm_source=github&utm_medium=listing&utm_campaign=maui-signaturepad-github-samples">www.syncfusion.com</a> | Toll Free: 1-888-9 DOTNET <br>
</p>