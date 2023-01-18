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
        Content = LauncherViewModel;
        
        // https://learn.microsoft.com/en-us/windows/communitytoolkit/mvvm/messenger#how-it-works
        WeakReferenceMessenger.Default.Register<MainViewChangedMessage>(this, (r, m) =>
        {
            Content = m.Value;
        });
    }
}
