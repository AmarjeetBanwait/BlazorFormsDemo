using BlazorFormsDemo;
using BlazorFormsDemo.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();

#region Core Forms

builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSystemWebAdapters()
	.AddPreApplicationStartMethod(true)
	.AddJsonSessionSerializer()
	.AddWrappedAspNetCoreSession()
	.AddRouting(defaultPage: "~/About.aspx")
	.AddHttpApplication<Global>(options =>
	{
		options.PoolSize = 10;
		options.RegisterModule<PageHandler>("PageHandler");
	})
	.AddWebForms()
.AddDynamicPages();
//.AddCompiledPages();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseSession();
app.UseSystemWebAdapters();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();
app.MapHttpHandlers();

app.Run();
