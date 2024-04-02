using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiSample.ViewModels;

public class ValueResetMessage : ValueChangedMessage<string>
{
    public ValueResetMessage(string message) : base(message)
    {
    }
}