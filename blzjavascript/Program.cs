using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using blzjavascript;
using blzcomponents.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.RootComponents.Add<App>("#app");
//builder.RootComponents.RegisterForJavaScript<Counter>(identifier: "counter", javaScriptInitializer: "loadApp");
builder.RootComponents.RegisterAsCustomElement<Counter>("xmasdev-counter");

builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
