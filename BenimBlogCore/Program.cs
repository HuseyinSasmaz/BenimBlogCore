using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using BenimBlogCore.Models.Context;
using BenimBlogCore.Models.Entity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<UygulamaKullanýcýsý, UygulamaRolu>(x =>
{

    x.Password.RequireDigit = true;
    x.Password.RequireLowercase = false;
    x.Password.RequireUppercase = false;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequiredLength = 6;
})
    .AddEntityFrameworkStores<Context>();
    

builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddMvc(config =>

{

	var policy = new AuthorizationPolicyBuilder()

					.RequireAuthenticatedUser()

					.Build();

	config.Filters.Add(new AuthorizeFilter(policy));

});

builder.Services.AddMvc();
builder.Services.AddAuthentication(
     CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x=>
     {
         x.LoginPath = "/Giris/Index/";
     }
    );
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true; 
    options.ExpireTimeSpan = TimeSpan.FromMinutes(100); 
    options.AccessDeniedPath = "/Login/ErisimEngeli/"; 
    options.LoginPath = "/Giris/Index/";
    options.SlidingExpiration = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/HataSayfasý/Hata1","?code=0");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseSession();   
app.UseRouting();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
 {
     endpoints.MapControllerRoute(
         name: "areas",
         pattern: "{area:exists}/{controller=WidgetController}/{action=Index}/{id?}"
     );

     endpoints.MapControllerRoute(
         name: "default",
         pattern: "{controller=Blog}/{action=Index}/{id?}"
         );
 });
app.Run();




