using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ScrollViewStrechesBeyondScreen.ViewModels.Messages
{
    public class RefreshDataBaseMessage : ValueChangedMessage<bool>
    {
        public RefreshDataBaseMessage(bool value) : base(value)
        {
            
        }
    }
}
