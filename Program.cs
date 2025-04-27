using Microsoft.Azure.Cosmos;

/*
Fixes build error happening because:
    The Cosmos DB .NET SDK expects you to use System.Text.Json for serialization (new standard).
    Sometimes, if your project or libraries (like old projects) rely on Newtonsoft.Json, there's a conflict.
*/
var builder = WebApplication.CreateBuilder(args);

Environment.SetEnvironmentVariable("AzureCosmosDisableNewtonsoftJsonCheck", "true");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton(s => 
{
    var config = builder.Configuration.GetSection("CosmosDb");
    return new CosmosClient(config["Account"]);
});

builder.Services.AddSingleton(s => 
{
    var config = builder.Configuration.GetSection("CosmosDb");
    var client = s.GetRequiredService<CosmosClient>();
    return client.GetDatabase(config["TrevonFirstCosmosAppDB"]);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
