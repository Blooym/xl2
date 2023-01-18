using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using XIVLauncher2.Messengers;

namespace XIVLauncher2.ViewModels;

public partial class SettingsViewModel : ViewModelBase 
{
    [RelayCommand]
    public void NavigateToLauncher()
    {
        WeakReferenceMessenger.Default.Send(new NavigationMessage(NavigationChange.Launcher));
    }
}
