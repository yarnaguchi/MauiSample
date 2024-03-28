namespace MauiSample;

public partial class App : Application
{
    public App()
    {
        Current.UserAppTheme = AppTheme.Light;

        InitializeComponent();

        // MainPage = new AppShell();
    }

    protected override Window CreateWindow(IActivationState activationState) =>
            new Window(new AppShell())
            {
                MinimumWidth = 1280,
                MinimumHeight = 580,
            };
}
