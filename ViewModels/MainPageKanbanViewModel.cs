using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiSample.Models;
using System.Collections.ObjectModel;

namespace MauiSample.ViewModels;


public partial class MainPageKanbanViewModel : ObservableObject
{
    // バーコードで読み取ったかんばんの情報
    [ObservableProperty]
    private ObservableCollection<Kanban> kanbans; // -> Kanbans

    // 供給先ライン
    [ObservableProperty]
    private string provideLine; // -> ProvideLine

    // おかもち連番
    [ObservableProperty]
    private string okamochiSeq; // -> OkamochiSeq

    // 合計かんばん枚数
    [ObservableProperty]
    private int kanbanCount; // -> KanbanCount

    public MainPageKanbanViewModel()
    {
        Kanbans = [];
        ProvideLine = "PD03";
        OkamochiSeq = "017";
        KanbanCount = 0;

        WeakReferenceMessenger.Default.Register<ValueResetMessage>(this, (recipient, message) =>
        {
            // Handle the message here, with r being the recipient and m being the
            // input message. Using the recipient passed as input makes it so that
            // the lambda expression doesn't capture "this", improving performance.
            if (message.Value == "reset")
            {
                Kanbans = [];
                ProvideLine = string.Empty;
                OkamochiSeq = string.Empty;
                KanbanCount = 0;
            }
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

