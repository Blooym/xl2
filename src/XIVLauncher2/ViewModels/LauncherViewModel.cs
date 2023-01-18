using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using XIVLauncher2.Messengers;

namespace XIVLauncher2.ViewModels;

public partial class LauncherViewModel : ViewModelBase
{
    [RelayCommand]
    public void NavigateToSettings()
    {
        WeakReferenceMessenger.Default.Send(new NavigationMessage((NavigationChange.Settings)));
    }
}
