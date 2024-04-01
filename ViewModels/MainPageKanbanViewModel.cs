using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MauiSample.ViewModels;

public class Kanban
{
    public string ProductNumber { get; set; }
    public string UniformNumber { get; set; }
    public string AccommodateNumber { get; set; }
}

public partial class MainPageKanbanViewModel : ObservableObject
{
    [ObservableProperty]
    private List<Kanban> kanbans; // -> Kanbans

    public MainPageKanbanViewModel()
    {
        Kanbans = [];
    }


    [RelayCommand]
    void Reset() // -> ResetCommand
    {
        Debug.WriteLine("kitayo");
        Kanbans.Add(new Kanban()
        {
            ProductNumber = "189750-000",
            UniformNumber = "◯✖️△□",
            AccommodateNumber = "30",
        });
    }
}

