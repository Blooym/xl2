using System.Reactive;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace XIVLauncher2.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _XIVLauncherText = "XIVLauncher";

    [RelayCommand]
    private void RunTheThing()
    {
        this.XIVLauncherText = "XIVLauncher TWO";
    }
}
