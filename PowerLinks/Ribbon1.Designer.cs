using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace PowerLinks
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.PowerLinks = this.Factory.CreateRibbonTab();
            this.Resources = this.Factory.CreateRibbonGroup();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.high_res_images = this.Factory.CreateRibbonMenu();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.PowerLinks.SuspendLayout();
            this.Resources.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PowerLinks
            // 
            this.PowerLinks.Groups.Add(this.Resources);
            this.PowerLinks.Label = "PowerLinks";
            this.PowerLinks.Name = "PowerLinks";
            // 
            // Resources
            // 
            this.Resources.Items.Add(this.buttonGroup1);
            this.Resources.Label = "Resources";
            this.Resources.Name = "Resources";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.high_res_images);
            this.buttonGroup1.Name = "buttonGroup1";
            // 
            // high_res_images
            // 
            this.high_res_images.Description = "Websites to download high resolution images.";
            this.high_res_images.Image = ((System.Drawing.Image)(resources.GetObject("high_res_images.Image")));
            this.high_res_images.Items.Add(this.button1);
            this.high_res_images.Items.Add(this.button2);
            this.high_res_images.Items.Add(this.button3);
            this.high_res_images.Items.Add(this.button4);
            this.high_res_images.Items.Add(this.button5);
            this.high_res_images.Label = "High Res Images";
            this.high_res_images.Name = "high_res_images";
            this.high_res_images.ShowImage = true;
            this.high_res_images.SuperTip = "Websites to download high resolution images.";
            // 
            // button1
            // 
            this.button1.Image = global::PowerLinks.Properties.Resources.svgviewer_output;
            this.button1.Label = "Pexels";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Tag = "https://www.pexels.com/zh-cn/";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OpenLink);
            // 
            // button2
            // 
            this.button2.Image = global::PowerLinks.Properties.Resources.iso_logo_small;
            this.button2.Label = "ISO Republic";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Tag = "https://isorepublic.com/";
            // 
            // button3
            // 
            this.button3.Image = global::PowerLinks.Properties.Resources.download;
            this.button3.Label = "Pic Jumbo";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            this.button3.Tag = "https://picjumbo.com/";
            // 
            // button4
            // 
            this.button4.Image = global::PowerLinks.Properties.Resources.svgviewer_output__1_;
            this.button4.Label = "Unsplash";
            this.button4.Name = "button4";
            this.button4.ShowImage = true;
            this.button4.Tag = "https://unsplash.com/";
            // 
            // button5
            // 
            this.button5.Image = global::PowerLinks.Properties.Resources.download__1_;
            this.button5.Label = "Hippopx";
            this.button5.Name = "button5";
            this.button5.ShowImage = true;
            this.button5.Tag = "https://www.hippopx.com/zh";
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.PowerLinks);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.PowerLinks.ResumeLayout(false);
            this.PowerLinks.PerformLayout();
            this.Resources.ResumeLayout(false);
            this.Resources.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab PowerLinks;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Resources;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu high_res_images;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;

        private void OpenLink(object sender, RibbonControlEventArgs e)
        {
            if (sender is RibbonButton)
            {
                RibbonButton button = (RibbonButton)sender;
                if (button.Tag is string)
                {
                    string tag = (string) button.Tag;
                    System.Diagnostics.Process.Start(tag);
                }
            }
        }

        internal RibbonButton button1;
        internal RibbonButton button2;
        internal RibbonButton button3;
        internal RibbonButton button4;
        internal RibbonButton button5;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
