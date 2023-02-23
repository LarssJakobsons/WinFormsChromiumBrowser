namespace WinFormsChromiumBrowser
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.AddTab = new System.Windows.Forms.Button();
            this.BrowserTabs = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(624, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(297, 20);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBack.Location = new System.Drawing.Point(922, 3);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 20);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // AddTab
            // 
            this.AddTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTab.Location = new System.Drawing.Point(594, 2);
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(24, 23);
            this.AddTab.TabIndex = 3;
            this.AddTab.Text = "+";
            this.AddTab.UseVisualStyleBackColor = true;
            this.AddTab.Click += new System.EventHandler(this.AddTab_Click_1);
            // 
            // BrowserTabs
            // 
            this.BrowserTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserTabs.Location = new System.Drawing.Point(0, 29);
            this.BrowserTabs.Name = "BrowserTabs";
            this.BrowserTabs.SelectedIndex = 0;
            this.BrowserTabs.Size = new System.Drawing.Size(1012, 487);
            this.BrowserTabs.TabIndex = 3;
            // 
            // Browser
            // 
            this.ClientSize = new System.Drawing.Size(1013, 516);
            this.Controls.Add(this.AddTab);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.BrowserTabs);
            this.Controls.Add(this.SearchBox);
            this.Name = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CefSharp.WinForms.ChromiumWebBrowser ChromiumBrowserWinforms;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button AddTab;
        private System.Windows.Forms.TabControl BrowserTabs;
    }
}

