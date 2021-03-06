using System;
using Smobiler.Core;
namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssSalesOrderEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssSalesOrderEdit()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.plAdd = new Smobiler.Core.Controls.Panel();
            this.btnAdd = new Smobiler.Core.Controls.Button();
            this.betGet = new Smobiler.Core.Controls.Button();
            this.plPOID = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.txtPOID = new Smobiler.Core.Controls.TextBox();
            this.ListATs = new Smobiler.Core.Controls.ListView();
            this.bsAss = new Smobiler.Core.Controls.BarcodeScanner();
            this.popMan = new Smobiler.Core.Controls.PopList();
            this.popCus = new Smobiler.Core.Controls.PopList();
            this.btnSave2 = new Smobiler.Core.Controls.Button();
            this.plRealID = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtRealID = new Smobiler.Core.Controls.TextBox();
            this.plName = new Smobiler.Core.Controls.Panel();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.plMan = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnDealMan = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.plCustomer = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btnCus = new Smobiler.Core.Controls.Button();
            this.label6 = new Smobiler.Core.Controls.Label();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产销售单编辑";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.btnDelete});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 468);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 102);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnSave.BorderRadius = 0;
            this.btnSave.Location = new System.Drawing.Point(12, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(276, 38);
            this.btnSave.Text = "保存";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(12, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 38);
            this.btnDelete.Text = "删除";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plAdd,
            this.plPOID,
            this.plRealID,
            this.plName,
            this.plMan,
            this.plCustomer});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 227);
            // 
            // plAdd
            // 
            this.plAdd.BackColor = System.Drawing.Color.White;
            this.plAdd.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plAdd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAdd,
            this.betGet});
            this.plAdd.Location = new System.Drawing.Point(0, 192);
            this.plAdd.Name = "plAdd";
            this.plAdd.Size = new System.Drawing.Size(300, 35);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnAdd.Location = new System.Drawing.Point(10, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 35);
            this.btnAdd.Text = "模板选择";
            this.btnAdd.Press += new System.EventHandler(this.btnAdd_Press);
            // 
            // betGet
            // 
            this.betGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.betGet.Location = new System.Drawing.Point(160, 0);
            this.betGet.Name = "betGet";
            this.betGet.Size = new System.Drawing.Size(130, 35);
            this.betGet.Text = "扫码添加";
            this.betGet.Press += new System.EventHandler(this.betGet_Press);
            // 
            // plPOID
            // 
            this.plPOID.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plPOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPOID.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.txtPOID});
            this.plPOID.Name = "plPOID";
            this.plPOID.Size = new System.Drawing.Size(300, 36);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(68, 36);
            this.label3.Text = "编号";
            // 
            // txtPOID
            // 
            this.txtPOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPOID.Location = new System.Drawing.Point(68, 0);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtPOID.ReadOnly = true;
            this.txtPOID.Size = new System.Drawing.Size(232, 36);
            // 
            // ListATs
            // 
            this.ListATs.BackColor = System.Drawing.Color.White;
            this.ListATs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListATs.Name = "ListATs";
            this.ListATs.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListATs.PageSizeTextSize = 11F;
            this.ListATs.ShowSplitLine = true;
            this.ListATs.Size = new System.Drawing.Size(300, 180);
            this.ListATs.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListATs.TemplateControlName = "frmAssSORowLayout";
            // 
            // bsAss
            // 
            this.bsAss.Name = "bsAss";
            this.bsAss.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bsAss_BarcodeScanned);
            // 
            // popMan
            // 
            this.popMan.Name = "popMan";
            this.popMan.Title = "采购人选择";
            this.popMan.Selected += new System.EventHandler(this.popDealMan_Selected);
            // 
            // popCus
            // 
            this.popCus.Name = "popCus";
            this.popCus.Selected += new System.EventHandler(this.popCus_Selected);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnSave2.BorderRadius = 0;
            this.btnSave2.Location = new System.Drawing.Point(262, 11);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(30, 13);
            this.btnSave2.Text = "保存";
            this.btnSave2.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // plRealID
            // 
            this.plRealID.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.txtRealID});
            this.plRealID.Location = new System.Drawing.Point(0, 36);
            this.plRealID.Name = "plRealID";
            this.plRealID.Size = new System.Drawing.Size(300, 36);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(68, 36);
            this.label2.Text = "实际编号";
            // 
            // txtRealID
            // 
            this.txtRealID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRealID.Location = new System.Drawing.Point(68, 0);
            this.txtRealID.Name = "txtRealID";
            this.txtRealID.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtRealID.Size = new System.Drawing.Size(232, 36);
            this.txtRealID.WaterMarkText = "（选填）";
            // 
            // plName
            // 
            this.plName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plName.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label7,
            this.txtName});
            this.plName.Location = new System.Drawing.Point(0, 72);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(300, 36);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(68, 36);
            this.Label7.Text = "名称";
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.Location = new System.Drawing.Point(68, 0);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtName.Size = new System.Drawing.Size(232, 36);
            this.txtName.WaterMarkText = "（必填）";
            // 
            // plMan
            // 
            this.plMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plMan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.btnDealMan,
            this.label1});
            this.plMan.Location = new System.Drawing.Point(0, 120);
            this.plMan.Name = "plMan";
            this.plMan.Size = new System.Drawing.Size(300, 36);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(68, 36);
            this.label4.Text = "销售人";
            // 
            // btnDealMan
            // 
            this.btnDealMan.BackColor = System.Drawing.Color.White;
            this.btnDealMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDealMan.BorderRadius = 0;
            this.btnDealMan.ForeColor = System.Drawing.Color.Black;
            this.btnDealMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnDealMan.Location = new System.Drawing.Point(68, 0);
            this.btnDealMan.Name = "btnDealMan";
            this.btnDealMan.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.btnDealMan.Size = new System.Drawing.Size(232, 36);
            this.btnDealMan.Text = "选择（必填）";
            this.btnDealMan.Press += new System.EventHandler(this.btnManager_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(274, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = ">";
            // 
            // plCustomer
            // 
            this.plCustomer.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plCustomer.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.btnCus,
            this.label6});
            this.plCustomer.Location = new System.Drawing.Point(0, 156);
            this.plCustomer.Name = "plCustomer";
            this.plCustomer.Size = new System.Drawing.Size(300, 36);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(68, 36);
            this.label5.Text = "客户";
            // 
            // btnCus
            // 
            this.btnCus.BackColor = System.Drawing.Color.White;
            this.btnCus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCus.BorderRadius = 0;
            this.btnCus.ForeColor = System.Drawing.Color.Black;
            this.btnCus.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnCus.Location = new System.Drawing.Point(68, 0);
            this.btnCus.Name = "btnCus";
            this.btnCus.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.btnCus.Size = new System.Drawing.Size(232, 36);
            this.btnCus.Text = "选择（必填）";
            this.btnCus.Press += new System.EventHandler(this.btnCus_Press);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(274, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 35);
            this.label6.Text = ">";
            // 
            // frmAssSalesOrderEdit
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.bsAss,
            this.popMan,
            this.popCus});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent,
            this.ListATs,
            this.btnSave2});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssSalesOrderEdit_KeyDown);
            this.Load += new System.EventHandler(this.frmAssSalesOrderEdit_Load);
            this.Name = "frmAssSalesOrderEdit";

        }
        #endregion

        private UserControl.Title Title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Panel plAdd;
        internal Smobiler.Core.Controls.Button btnAdd;
        internal Smobiler.Core.Controls.Button betGet;
        private Smobiler.Core.Controls.Panel plPOID;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.TextBox txtPOID;
        private Smobiler.Core.Controls.ListView ListATs;
        private Smobiler.Core.Controls.BarcodeScanner bsAss;
        private Smobiler.Core.Controls.PopList popMan;
        private Smobiler.Core.Controls.PopList popCus;
        internal Smobiler.Core.Controls.Button btnDelete;
        private Smobiler.Core.Controls.Button btnSave2;
        private Smobiler.Core.Controls.Panel plRealID;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.TextBox txtRealID;
        private Smobiler.Core.Controls.Panel plName;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.TextBox txtName;
        private Smobiler.Core.Controls.Panel plMan;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Button btnDealMan;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel plCustomer;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Button btnCus;
        private Smobiler.Core.Controls.Label label6;
    }
}