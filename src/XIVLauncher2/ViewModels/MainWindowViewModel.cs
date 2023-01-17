using CommunityToolkit.Mvvm.ComponentModel;

namespace XIVLauncher2.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] 
    public ViewModelBase _Content;
    
    public LauncherViewModel LauncherViewModel { get; }

    public MainWindowViewModel()
    {
        //this.Content = this.LauncherViewModel = new LauncherViewModel();
        this.LauncherViewModel = new LauncherViewModel();
        this.Content = this.LauncherViewModel;
    }
}
