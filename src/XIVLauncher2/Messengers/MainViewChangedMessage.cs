using CommunityToolkit.Mvvm.Messaging.Messages;
using XIVLauncher2.ViewModels;

namespace XIVLauncher2.Messengers;

public class MainViewChangedMessage : ValueChangedMessage<ViewModelBase>
{
    public MainViewChangedMessage(ViewModelBase view) : base(view)
    {
    }
}
