using LuceCarterWebsite.Components;
using Contentful.AspNetCore;
using Contentful.Core;
using Contentful.Core.Models.Management;
using LuceCarterWebsite.Models;
using LuceCarterWebsite.Services;

var builder = WebApplication.CreateBuilder(args);

var contentfulOptions = builder.Configuration.GetSection("ContentfulOptions").Get<ContentfulOptions>();
builder.Services.Configure<ContentfulOptions>(builder.Configuration.GetSection("ContentfulOptions"));
builder.Services.AddScoped<ContentfulService>(service => new ContentfulService(contentfulOptions));


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddContentful(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();