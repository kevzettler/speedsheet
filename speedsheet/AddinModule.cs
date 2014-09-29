using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using AddinExpress.MSO;

namespace speedsheet
{
    /// <summary>
    ///   Add-in Express Add-in Module
    /// </summary>
    [GuidAttribute("4EB59888-96CF-49C5-B272-9900177E6E3A"), ProgId("speedsheet.AddinModule")]
    public partial class AddinModule : AddinExpress.MSO.ADXAddinModule
    {
        public AddinModule()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            // Please add any initialization code to the AddinInitialize event handler
        }
 
        #region Add-in Express automatic code
 
        // Required by Add-in Express - do not modify
        // the methods within this region
 
        public override System.ComponentModel.IContainer GetContainer()
        {
            if (components == null)
                components = new System.ComponentModel.Container();
            return components;
        }
 
        [ComRegisterFunctionAttribute]
        public static void AddinRegister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXRegister(t);
        }
 
        [ComUnregisterFunctionAttribute]
        public static void AddinUnregister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXUnregister(t);
        }
 
        public override void UninstallControls()
        {
            base.UninstallControls();
        }

        #endregion

        public static new AddinModule CurrentInstance 
        {
            get
            {
                return AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
            }
        }

        public Excel._Application ExcelApp
        {
            get
            {
                return (HostApplication as Excel._Application);
            }
        }

        private void adxRibbonButton1_OnClick(object sender, IRibbonControl control, bool pressed)
        {
          getSelectedCells();
        }

        private void getSelectedCells()
        {
            Excel.Range selectedCellsRange = null;
            Excel.Range columnRange = null;
            Excel.Range rowRange = null;
            int numberOfColumns = 0;
            int numberOfRows = 0;

            try
            {
                if (ExcelApp.Selection is Excel.Range)
                {
                    selectedCellsRange = ExcelApp.Selection as Excel.Range;
                    columnRange = selectedCellsRange.Columns;
                    rowRange = selectedCellsRange.Rows;
                    numberOfColumns = columnRange.Count;
                    numberOfRows = rowRange.Count;
                    MessageBox.Show(String.Format(
                        "You've selected {0} columns and {1} rows. The selection address is {2}",
                        numberOfColumns, numberOfRows, selectedCellsRange.Address));
                }

            }
            finally
            {
                if (rowRange != null) Marshal.ReleaseComObject(rowRange);
                if (columnRange != null) Marshal.ReleaseComObject(columnRange);
                if (selectedCellsRange != null) Marshal.ReleaseComObject(selectedCellsRange);
            }
        }


    }
}

