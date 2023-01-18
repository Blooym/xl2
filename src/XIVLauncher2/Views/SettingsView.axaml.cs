using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace XIVLauncher2.Views;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}

