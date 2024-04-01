using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiSample.ViewModels;

public partial class MainPageKanbanViewModel : ObservableObject
{
    [ObservableProperty]
    private string okamochiQr; // -> OkamochiQr

    [ObservableProperty]
    private string kanbanQr; // -> KanbanQr

    public MainPageKanbanViewModel()
    {
        OkamochiQr = "OKA_F_    PD03_017";
        KanbanQr = "◯✖️△□";
    }


    [RelayCommand]
    void Reset() // -> ResetCommand
    {
        OkamochiQr = string.Empty;
        KanbanQr = string.Empty;
    }
}

