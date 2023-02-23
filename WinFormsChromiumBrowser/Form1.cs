using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsChromiumBrowser
{
    public partial class Browser : Form
    {
        ChromiumWebBrowser ChromiumBrowser = null;
        int page_num = 1;

        public Browser()
        {
            InitializeComponent();
            InitializeBrowser();
        }
        public void InitializeBrowser()
        {
            var settings = new CefSettings();
            Cef.Initialize(settings);
            ChromiumBrowser = new ChromiumWebBrowser("https://www.google.lv/search?q=balls");
            //this.Controls.Add(ChromiumBrowser);

            TabPage tabPage = new TabPage();
            tabPage.Text = $"Page {page_num}";
            page_num = page_num + 1;

            ChromiumBrowser = new ChromiumWebBrowser("https://google.com");
            tabPage.Controls.Add(ChromiumBrowser);
            ChromiumBrowser.Dock = DockStyle.Fill;

            BrowserTabs.TabPages.Add(tabPage);

        }

        private void ChromiumBrowserFormApp_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            //TODO: Find an alternative that works
            try
            {
                ChromiumBrowser.Load(SearchBox.Text);
            }
            catch 
            {
                ChromiumBrowser.Load($"https://www.google.lv/search?q={SearchBox.Text}");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (ChromiumBrowser.CanGoBack)
            {
                ChromiumBrowser.Back();
            }
        }

        private void AddTab_Click_1(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = $"Page {page_num}";
            page_num = page_num + 1 ;

            ChromiumBrowser = new ChromiumWebBrowser("https://google.com");
            tabPage.Controls.Add(ChromiumBrowser);
            ChromiumBrowser.Dock = DockStyle.Fill;

            BrowserTabs.TabPages.Add(tabPage);
        }
    }
}
