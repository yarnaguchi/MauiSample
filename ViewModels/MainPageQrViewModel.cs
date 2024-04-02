using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiSample.ViewModels;

public class ValueResetMessage : ValueChangedMessage<bool>
{
    public ValueResetMessage(bool reset) : base(reset)
    {
    }
}
public partial class MainPageQrViewModel : ObservableObject
{
    [ObservableProperty]
    private string okamochiQr; // -> OkamochiQr

    [ObservableProperty]
    private string kanbanQr; // -> KanbanQr

    public MainPageQrViewModel()
    {
        OkamochiQr = "OKA_F_    PD03_017";
        KanbanQr = "◯✖️△□";
    }


    [RelayCommand]
    void Reset() // -> ResetCommand
    {
        OkamochiQr = string.Empty;
        KanbanQr = string.Empty;

        WeakReferenceMessenger.Default.Send(new ValueResetMessage(true));
    }
}

