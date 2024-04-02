using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiSample.ViewModels;

public partial class MainPageHeaderViewModel : ObservableObject
{
    [ObservableProperty]
    private string department; // -> Department

    [ObservableProperty]
    private string userName; // -> UserName

    public MainPageHeaderViewModel()
    {
        Department = "ｾｲﾌﾃｨ第1生産部";
        UserName = "C4117 大山 太一";
    }

    [RelayCommand]
    async Task Close() // -> CloseCommand
    {
        UserName = "adfadsfasdf";
        bool ans = await Application.Current.MainPage.DisplayAlert("確認", "アプリを終了します。よろしいですか？", "Yes", "No");
        if (ans == true)
        {
            // アプリ（ウィンドウ）を閉じる
            Application.Current.Quit();
        }
    }
}

