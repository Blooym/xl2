using CommunityToolkit.Mvvm.Messaging.Messages;

namespace XIVLauncher2.Messengers;

public class NavigationMessage : ValueChangedMessage<NavigationChange>
{
    public NavigationMessage(NavigationChange view) : base(view)
    {
    }
}

public enum NavigationChange
{
    Launcher,
    Settings,
}
