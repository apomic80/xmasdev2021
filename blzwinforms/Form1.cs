using blzcomponents;
using blzcomponents.Services;
using blzcomponents.Pages;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using blzwinforms.Services;

namespace blzwinforms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddBlazorWebView();
        serviceCollection.AddSingleton<IDataService, DataService>();
        var blazor = new BlazorWebView()
        {
            Dock = DockStyle.Fill,
            HostPage = "wwwroot/index.html",
            Services = serviceCollection.BuildServiceProvider(),
        };
        blazor.RootComponents.Add<App>("#app");
        Controls.Add(blazor);
    }
}
