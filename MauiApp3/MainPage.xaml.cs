namespace MauiApp3;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

        var htmlSrc = "https://www.youtube.com/embed/aK4JSwhdcdE";
        var videoSource = new HtmlWebViewSource()
        {
            Html = @"<html><head><meta name ='viewport' content ='width=device-width,initial-scale=1,maximum-scale=1'/></head><body><div style=' position: relative; padding-bottom: 56.25%; padding-top: 25px;'> <iframe style='position: absolute; top: 0; left: 0; width: 100%; height: 100%;'  src='" + htmlSrc + "' frameborder='0'></iframe></div> </body></html>",
        };

        WebView1.Source = videoSource;
        WebView2.Source = videoSource;
        WebView3.Source = videoSource;
        WebView4.Source = videoSource;
        WebView5.Source = videoSource;
        WebView6.Source = videoSource;
    }
}

