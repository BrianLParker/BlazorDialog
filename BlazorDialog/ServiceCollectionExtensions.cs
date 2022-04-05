using Microsoft.Extensions.DependencyInjection;

namespace BlazorDialog;

public static class ServiceCollectionExtensions
{
    public static void AddBlazorDialog(this IServiceCollection services)
    {
        services.AddScoped<IDialogService, DialogService>();
    }
}
