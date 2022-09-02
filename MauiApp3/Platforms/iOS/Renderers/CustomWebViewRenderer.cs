using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using WebKit;

namespace MauiApp3.Platforms.iOS.Renderers
{
    class CustomWebViewRenderer : WkWebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            try
            {
                base.OnElementChanged(e);

                NavigationDelegate = new ExtendedWKWebViewDelegate(this);

                var wv = Element as WebView;

                // For fixing white flash issue in webview on dark themes/backgrounds and disable webview's scrolling
                if (NativeView != null)
                {
                    var webView = (WKWebView)NativeView;

                    webView.Opaque = false;
                    webView.BackgroundColor = UIColor.Clear;
                    webView.ScrollView.ScrollEnabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at ExtendedWebViewRenderer OnElementChanged: " + ex.Message);
            }
        }
    }

    class ExtendedWKWebViewDelegate : WKNavigationDelegate
    {
        CustomWebViewRenderer webViewRenderer;

        public ExtendedWKWebViewDelegate(CustomWebViewRenderer _webViewRenderer)
        {
            webViewRenderer = _webViewRenderer ?? new CustomWebViewRenderer();
        }

        public override async void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
        {
            var wv = webViewRenderer.Element as WebView;

            if (wv != null && webView != null)
            {
                await System.Threading.Tasks.Task.Delay(100); // wait here till content is rendered
                if (webView.ScrollView != null && webView.ScrollView.ContentSize != null)
                {
                    wv.HeightRequest = (double)webView.ScrollView.ContentSize.Height;
                }
            }
        }
    }
}
