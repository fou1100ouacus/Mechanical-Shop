using MechanicShop.Api.Components;
using MechanicShop.Infrastructure.Data;
using MechanicShop.Infrastructure.RealTime;

using Scalar.AspNetCore;

using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services
    .AddPresentation(builder.Configuration)
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.Host.UseSerilog((context, loggerConfig) =>
    loggerConfig.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "MechanicShop API V1");

        options.EnableDeepLinking();
        options.DisplayRequestDuration();
        options.EnableFilter();
    });

    app.MapScalarApiReference();

    await app.InitialiseDatabaseAsync();

    app.UseWebAssemblyDebugging();
}
else
{
    app.UseHsts();

    // Demo data seeding is disabled in production unless explicitly enabled.
    if (builder.Configuration.GetValue<bool>("Database:SeedDemoData"))
    {
        if (string.IsNullOrWhiteSpace(builder.Configuration["Database:InitialUserPassword"]))
        {
            throw new InvalidOperationException(
                "Database:InitialUserPassword must be configured before production demo data seeding.");
        }

        await app.InitialiseDatabaseAsync();
    }
}

app.UseCoreMiddlewares(builder.Configuration);

app.MapControllers();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>().AllowAnonymous()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(MechanicShop.Client._Imports).Assembly);

app.MapHub<WorkOrderHub>("/hubs/workorders");

app.Run();