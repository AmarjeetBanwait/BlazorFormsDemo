using BlazorFormsDemo;
using BlazorFormsDemo.Components;

var builder = WebApplication.CreateBuilder(args);
builder.UseWebConfig(isOptional: false);

builder.Services.AddResponseCompression();
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
#if WEBFORMS_DYNAMIC
    .AddDynamicPages();
#else
    .AddCompiledPages();
#endif

#endregion

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseResponseCompression();
app.UseResponseCaching();
app.UseHttpsRedirection();

app.UseRouting();

app.UseSession();
app.UseSystemWebAdapters();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();
app.MapHttpHandlers();

app.Run();
