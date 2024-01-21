using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ScrollViewStrechesBeyondScreen.ViewModels.Messages
{
    public class UpdateSelectedStoreItemsMessage : ValueChangedMessage<bool>
    {
        public UpdateSelectedStoreItemsMessage(bool value) : base(value)
        {
            
        }
    }
}
