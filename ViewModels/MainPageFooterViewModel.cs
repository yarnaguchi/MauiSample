using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace MauiSample.ViewModels;

public partial class MainPageFooterViewModel : ObservableObject
{

    [ObservableProperty]
    private string startPath; // -> StartPath

    [ObservableProperty]
    private string stopPath; // -> StopPath

    [ObservableProperty]
    private string okamochiPath; // -> OkamochiPath

    public MainPageFooterViewModel()
    {
        StartPath = "¥¥tr¥dfs¥生産管理部¥Share¥C230_業務支援G¥C26_他部署提供ツール¥電子棚札¥大口組立生産部¥00_ESL_DATA¥FP_01¥START";
        StopPath = "¥¥tr¥dfs¥生産管理部¥Share¥C230_業務支援G¥C26_他部署提供ツール¥電子棚札¥大口組立生産部¥00_ESL_DATA¥FP_01¥STOP";
        OkamochiPath = "¥¥tr¥dfs¥生産管理部¥Share¥C230_業務支援G¥C26_他部署提供ツール¥電子棚札¥大口組立生産部¥00_ESL_DATA¥FP_01¥OKAMOCHI";

        WeakReferenceMessenger.Default.Register<ValueResetMessage>(this, (recipient, message) =>
        {
            // Handle the message here, with r being the recipient and m being the
            // input message. Using the recipient passed as input makes it so that
            // the lambda expression doesn't capture "this", improving performance.
            if (message.Value == "reset")
            {
                StartPath = string.Empty;
                StopPath = string.Empty;
                OkamochiPath = string.Empty;
            }
        });
    }
}

