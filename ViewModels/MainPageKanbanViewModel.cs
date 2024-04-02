using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiSample.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiSample.ViewModels;


public partial class MainPageKanbanViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Kanban> kanbans; // -> Kanbans

    public MainPageKanbanViewModel()
    {
        Kanbans = [];
        Kanbans.Add(new Kanban()
        {
            ProductNumber = "189750-000",
            UniformNumber = "◯✖️△□",
            AccommodateNumber = "30",
        });
        Kanbans.Add(new Kanban()
        {
            ProductNumber = "189750-000",
            UniformNumber = "◯✖️△□",
            AccommodateNumber = "30",
        });
        Kanbans.Add(new Kanban()
        {
            ProductNumber = "189750-000",
            UniformNumber = "◯✖️△□",
            AccommodateNumber = "30",
        });
        Kanbans.Add(new Kanban()
        {
            ProductNumber = "189750-000",
            UniformNumber = "◯✖️△□",
            AccommodateNumber = "30",
        });
        Kanbans.Add(new Kanban()
        {
            ProductNumber = "189750-000",
            UniformNumber = "◯✖️△□",
            AccommodateNumber = "30",
        });
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

