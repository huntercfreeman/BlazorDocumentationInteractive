using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using MudBlazor.Services;

namespace BlazorDocumentationInteractive.RazorClassLibrary;

public static class BlazorDocumentationInteractiveExtensions
{
    public static IServiceCollection AddBlazorDocumentationInteractiveRazorClassLibraryServices(this IServiceCollection services)
    {
        return services
            .AddMudServices();
    }
}