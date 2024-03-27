namespace MauiSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	async void OnCloseClicked(object sender, EventArgs e)
	{
		bool ans = await DisplayAlert("確認", "アプリを終了します。よろしいですか？", "Yes", "No");

		if (ans == true)
		{
			// アプリ（ウィンドウ）を閉じる
			Application.Current.Quit();
		}
	}
}