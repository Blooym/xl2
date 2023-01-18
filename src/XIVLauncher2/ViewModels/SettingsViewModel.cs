using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using XIVLauncher2.Messengers;

namespace XIVLauncher2.ViewModels;

public partial class SettingsViewModel : ViewModelBase 
{
    [RelayCommand]
    public void NavigateToLauncher()
    {
        // TODO: This is totally wrong for navigation as we use memory on every navigation.
        WeakReferenceMessenger.Default.Send(new MainViewChangedMessage(new LauncherViewModel()));
    }
}
