using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace XIVLauncher2.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] 
    public ViewModelBase _Content;

    public LauncherViewModel LauncherViewModel { get; } = new();
    public SettingsViewModel SettingsViewModel { get; } = new();

    public MainWindowViewModel()
    {
        Content = LauncherViewModel;
    }

    [RelayCommand]
    private void NavigateToSettingsCommand()
    {
        this.Content = this.SettingsViewModel;   
    }

    [RelayCommand]
    private void NavigateToLauncherCommand()
    {
        this.Content = this.SettingsViewModel;   
    }
}
