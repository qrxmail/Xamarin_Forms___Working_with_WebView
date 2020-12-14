using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebPage : ContentPage
    {
        WebView browser;
        public WebPage()
        {
            browser = new WebView();
            browser.Source = "http://117.34.91.69:12319/user/login";
            browser.HeightRequest = 1000;
            browser.WidthRequest = 1000;
            Content = browser;
        }

        /// <summary>
        /// 后退按钮退回到上一页
        /// </summary>
        /// <returns></returns>
        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            if (browser.CanGoBack)
            {
                browser.GoBack();
                return true;
            }
            else
            {
                base.OnBackButtonPressed();
                return false;
            }
        }
    }
}

