using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDocs.RazorClassLib.Layout;

public partial class LayoutDisplay : LayoutComponentBase
{
    bool _isDarkMode = true;
    bool _drawerOpen = true;

    private string ToggleThemeIcon => _isDarkMode
        ? MudBlazor.Icons.Filled.LightMode
        : MudBlazor.Icons.Filled.DarkMode;

    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
}
