using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ScrollViewStrechesBeyondScreen.ViewModels.Messages
{
    public class SelectedViewChangedMessage : ValueChangedMessage<byte>
    {
        public SelectedViewChangedMessage(byte selectedViewIndex) : base(selectedViewIndex)
        {
            
        }
    }
}
