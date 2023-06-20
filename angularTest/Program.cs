//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();


//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");

//app.MapFallbackToFile("index.html");

//app.Run();


using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.Run();


//******************************************************
//void Startup(IConfiguration configuration)
//{
//    var Configuration = configuration;
//}

//void ConfigureServices(IServiceCollection services)
//{
//    // Other service configurations

//    services.AddMemoryCache();
//    services.Configure<IpRateLimitOptions>(Configuration.GetSection("IpRateLimiting"));
//    services.Configure<IpRateLimitPolicies>(Configuration.GetSection("IpRateLimitPolicies"));
//    services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
//    services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
//    services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
//}

//app.UseIpRateLimiting();
//******************************************************


//UNHIDE THIS OR DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;



// Startup(IConfiguration configuration)
//{
//    Configuration = configuration;
//}

//public IConfiguration Configuration { get; }



//public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//{
//    // Other middleware configurations

//    app.UseIpRateLimiting();

//    // Other middleware configurations
//}


