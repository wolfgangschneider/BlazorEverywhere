namespace Tpl.Maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        // use Blazor menu included in Tpl.Core like Blazor-Server/WASM
        //MainPage = new MainPage();

        // Use own Maui menu e.g TabbedPage
        MainPage = new MainPageTabbed();
    }
}
