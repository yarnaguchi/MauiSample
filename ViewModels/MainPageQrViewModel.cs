using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace MauiSample.ViewModels;

public partial class MainPageQrViewModel : ObservableObject
{
    // おかもちＱＲ
    [ObservableProperty]
    private string okamochiQr; // -> OkamochiQr

    // 仕掛かんばんＱＲ
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

        WeakReferenceMessenger.Default.Send(new ValueResetMessage("reset"));
    }
}

