namespace speedsheet
{
    partial class AddinModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
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
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinModule));
            this.speedSheetTab = new AddinExpress.MSO.ADXRibbonTab(this.components);
            this.adxRibbonGroup1 = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxRibbonButton1 = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.adxExcelEvents = new AddinExpress.MSO.ADXExcelAppEvents(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            // 
            // speedSheetTab
            // 
            this.speedSheetTab.Caption = "Speed Sheets";
            this.speedSheetTab.Controls.Add(this.adxRibbonGroup1);
            this.speedSheetTab.Id = "adxRibbonTab_f6a8e2aa5ba14e60861b26fc316c9afb";
            this.speedSheetTab.Ribbons = AddinExpress.MSO.ADXRibbons.msrExcelWorkbook;
            // 
            // adxRibbonGroup1
            // 
            this.adxRibbonGroup1.Caption = "streams";
            this.adxRibbonGroup1.Controls.Add(this.adxRibbonButton1);
            this.adxRibbonGroup1.Id = "adxRibbonGroup_e705281a918f4da2b1656ea3846ce91b";
            this.adxRibbonGroup1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonGroup1.Ribbons = AddinExpress.MSO.ADXRibbons.msrExcelWorkbook;
            // 
            // adxRibbonButton1
            // 
            this.adxRibbonButton1.Caption = "Create Stream";
            this.adxRibbonButton1.Id = "adxRibbonButton_2d67b8c91dcd4afab835a6251f3b5720";
            this.adxRibbonButton1.Image = 0;
            this.adxRibbonButton1.ImageList = this.imageList1;
            this.adxRibbonButton1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonButton1.Ribbons = AddinExpress.MSO.ADXRibbons.msrExcelWorkbook;
            this.adxRibbonButton1.Size = AddinExpress.MSO.ADXRibbonXControlSize.Large;
            this.adxRibbonButton1.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButton1_OnClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rsz_1icons.jpg");
            // 
            // AddinModule
            // 
            this.AddinName = "speedsheet";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaExcel;

        }
        #endregion

        private AddinExpress.MSO.ADXRibbonTab speedSheetTab;
        private AddinExpress.MSO.ADXRibbonGroup adxRibbonGroup1;
        private AddinExpress.MSO.ADXRibbonButton adxRibbonButton1;
        private System.Windows.Forms.ImageList imageList1;
        private AddinExpress.MSO.ADXExcelAppEvents adxExcelEvents;
    }
}

