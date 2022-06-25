using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using MudBlazor.Services;

namespace BlazorDocs.RazorClassLib;

public static class BlazorDocsExtensions
{
    public static IServiceCollection AddBlazorDocsRazorClassLibServices(this IServiceCollection services)
    {
        return services
            .AddMudServices();
    }
}