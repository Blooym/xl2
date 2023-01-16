using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace XIVLauncher2.Views;

public partial class LauncherView : UserControl
{
    public LauncherView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
