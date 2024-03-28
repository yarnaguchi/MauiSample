using System.Collections.ObjectModel;

namespace MauiSample;

public class ProductRecord
{
    public ObservableCollection<ProductRecord> ProductRecords { get; private set; } = new ObservableCollection<ProductRecord>();

    public ProductRecord()
    {
        ProductRecords.Add(new ProductRecord()
        {
            ProductNumber = "189750-000",
            UniformNumber = "◯✖️△□",
            AccommodateNumber = 30,
        });

    }
    public string ProductNumber { get; set; }
    public string UniformNumber { get; set; }
    public int AccommodateNumber { get; set; }
}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        // BindingContext = new ProductRecord();
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

    async void OnResetClicked(object sender, EventArgs e)
    {
        await DisplayAlert("テスト", "[リセット]ボタンクリック", "Yes", "No");
    }

    async void OnBindClicked(object sender, EventArgs e)
    {
        await DisplayAlert("テスト", "[紐づけ処理]ボタンクリック", "Yes", "No");
    }

    void OnAddProductRecordClicked(object sender, EventArgs e)
    {
        // ProductRecords.Add(new ProductRecord()
        // {
        //     ProductNumber = "189750-000",
        //     UniformNumber = "◯✖️△□",
        //     AccommodateNumber = 30,
        // });
    }

}
