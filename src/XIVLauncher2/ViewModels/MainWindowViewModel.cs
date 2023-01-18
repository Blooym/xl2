using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using XIVLauncher2.Messengers;

namespace XIVLauncher2.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] 
    public ViewModelBase _Content;

    public LauncherViewModel LauncherViewModel { get; } = new();
    public SettingsViewModel SettingsViewModel { get; } = new();

    public MainWindowViewModel()
    {
        this.Content = LauncherViewModel;
        WeakReferenceMessenger.Default.Register<NavigationMessage>(this, (_, m) => this.HandleNavigationMessage(m));
    }
    
    private void HandleNavigationMessage(NavigationMessage message)
    {
        switch (message.Value)
        {
            case NavigationChange.Launcher:
                this.Content = LauncherViewModel;
                break;
            case  NavigationChange.Settings:
                this.Content = SettingsViewModel;
                break;
        }
    }
}
