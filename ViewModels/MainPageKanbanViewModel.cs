using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiSample.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiSample.ViewModels;


public partial class MainPageKanbanViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Kanban> kanbans; // -> Kanbans

    [ObservableProperty]
    private int kanbanCount; // -> KanbanCount


    public MainPageKanbanViewModel()
    {
        Kanbans = [];
        KanbanCount = 0;

        WeakReferenceMessenger.Default.Register<ValueResetMessage>(this, (r, m) =>
        {
            // Handle the message here, with r being the recipient and m being the
            // input message. Using the recipient passed as input makes it so that
            // the lambda expression doesn't capture "this", improving performance.
            Debug.WriteLine(r);
            Debug.WriteLine(m);
        });
    }

    [RelayCommand]
    void AddData() // -> AddDataCommand
    {
        Kanbans.Add(new Kanban()
        {
            ProductNumber = "189750-000",
            UniformNumber = "◯✖️△□",
            AccommodateNumber = "30",
        });
        KanbanCount = Kanbans.Count;
    }

    [RelayCommand]
    async Task Bind() // -> BindCommand
    {
        await Application.Current.MainPage.DisplayAlert("テスト", "[紐づけ処理]ボタンクリック", "Yes", "No");
    }
}

