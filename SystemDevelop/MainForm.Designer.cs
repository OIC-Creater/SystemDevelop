namespace SystemDevelop
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainOfficeManuBar = new SystemDevelop.UserControls.MainOfficeManuBar();
            this.headerLists = new SystemDevelop.UserControls.HeaderLists();
            this.headerControl = new SystemDevelop.UserControls.Header();
            this.settingConfi = new SystemDevelop.UserControls.SettingConfi();
            this.reciveControl = new SystemDevelop.UserControls.ReciveAdd();
            this.newProduct = new SystemDevelop.UserControls.NewProduct();
            this.warehouseMenuBar = new SystemDevelop.UserControls.WarehouseMenuBar();
            this.loginControl = new SystemDevelop.UserControls.Login();
            this.salesMenuBar = new SystemDevelop.UserControls.SalesMenuBar();
            this.manufactureList = new SystemDevelop.UserControls.ManufactureList();
            this.shopList = new SystemDevelop.UserControls.ShopList();
            this.businesOfficeList = new SystemDevelop.UserControls.SalesOfficeList();
            this.empList = new SystemDevelop.UserControls.EmpList();
            this.unDispatched = new SystemDevelop.UserControls.PlaceAnOrderList();
            this.pigeonList = new SystemDevelop.UserControls.PigeonList();
            this.stockList = new SystemDevelop.UserControls.StockList();
            this.warehouseControl = new SystemDevelop.UserControls.StockList();
            this.placeControl = new SystemDevelop.UserControls.PlaceAnOrderList();
            this.orderControl = new SystemDevelop.UserControls.ReciveList();
            this.SuspendLayout();
            // 
            // mainOfficeManuBar
            // 
            this.mainOfficeManuBar.Location = new System.Drawing.Point(0, 81);
            this.mainOfficeManuBar.Name = "mainOfficeManuBar";
            this.mainOfficeManuBar.Size = new System.Drawing.Size(220, 789);
            this.mainOfficeManuBar.TabIndex = 1;
            this.mainOfficeManuBar.Visible = false;
            this.mainOfficeManuBar.Load += new System.EventHandler(this.mainOfficeManuBar_Load);
            // 
            // headerLists
            // 
            this.headerLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLists.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerLists.Location = new System.Drawing.Point(219, 81);
            this.headerLists.Name = "headerLists";
            this.headerLists.Size = new System.Drawing.Size(1045, 77);
            this.headerLists.TabIndex = 2;
            this.headerLists.Visible = false;
            // 
            // headerControl
            // 
            this.headerControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerControl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.headerControl.Location = new System.Drawing.Point(0, -2);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1264, 83);
            this.headerControl.TabIndex = 4;
            this.headerControl.Visible = false;
            // 
            // settingConfi
            // 
            this.settingConfi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingConfi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingConfi.Location = new System.Drawing.Point(622, 329);
            this.settingConfi.Name = "settingConfi";
            this.settingConfi.Size = new System.Drawing.Size(280, 120);
            this.settingConfi.TabIndex = 5;
            this.settingConfi.Visible = false;
            // 
            // reciveControl
            // 
            this.reciveControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveControl.Location = new System.Drawing.Point(219, 81);
            this.reciveControl.Name = "reciveControl";
            this.reciveControl.Size = new System.Drawing.Size(1033, 706);
            this.reciveControl.TabIndex = 3;
            this.reciveControl.Visible = false;
            // 
            // newProduct
            // 
            this.newProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProduct.Location = new System.Drawing.Point(219, 81);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(1045, 710);
            this.newProduct.TabIndex = 3;
            this.newProduct.Visible = false;
            // 
            // warehouseMenuBar
            // 
            this.warehouseMenuBar.Location = new System.Drawing.Point(0, 81);
            this.warehouseMenuBar.Name = "warehouseMenuBar";
            this.warehouseMenuBar.Size = new System.Drawing.Size(221, 789);
            this.warehouseMenuBar.TabIndex = 1;
            this.warehouseMenuBar.Visible = false;
            // 
            // loginControl
            // 
            this.loginControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginControl.Location = new System.Drawing.Point(0, 1);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(1264, 786);
            this.loginControl.TabIndex = 10;
            // 
            // salesMenuBar
            // 
            this.salesMenuBar.Location = new System.Drawing.Point(0, 81);
            this.salesMenuBar.Name = "salesMenuBar";
            this.salesMenuBar.Size = new System.Drawing.Size(222, 789);
            this.salesMenuBar.TabIndex = 0;
            this.salesMenuBar.Visible = false;
            // 
            // manufactureList
            // 
            this.manufactureList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manufactureList.Location = new System.Drawing.Point(219, 158);
            this.manufactureList.Name = "manufactureList";
            this.manufactureList.Size = new System.Drawing.Size(1045, 627);
            this.manufactureList.TabIndex = 3;
            this.manufactureList.Visible = false;
            // 
            // shopList
            // 
            this.shopList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopList.Location = new System.Drawing.Point(219, 158);
            this.shopList.Name = "shopList";
            this.shopList.Size = new System.Drawing.Size(1045, 633);
            this.shopList.TabIndex = 3;
            this.shopList.Visible = false;
            // 
            // businesOfficeList
            // 
            this.businesOfficeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.businesOfficeList.Location = new System.Drawing.Point(219, 158);
            this.businesOfficeList.Name = "businesOfficeList";
            this.businesOfficeList.Size = new System.Drawing.Size(1045, 633);
            this.businesOfficeList.TabIndex = 3;
            this.businesOfficeList.Visible = false;
            // 
            // empList
            // 
            this.empList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empList.Location = new System.Drawing.Point(219, 158);
            this.empList.Name = "empList";
            this.empList.Size = new System.Drawing.Size(1045, 633);
            this.empList.TabIndex = 3;
            this.empList.Visible = false;
            // 
            // unDispatched
            // 
            this.unDispatched.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unDispatched.Location = new System.Drawing.Point(219, 158);
            this.unDispatched.Name = "unDispatched";
            this.unDispatched.Size = new System.Drawing.Size(1045, 633);
            this.unDispatched.TabIndex = 3;
            this.unDispatched.Visible = false;
            // 
            // pigeonList
            // 
            this.pigeonList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonList.Location = new System.Drawing.Point(219, 158);
            this.pigeonList.Name = "pigeonList";
            this.pigeonList.Size = new System.Drawing.Size(1045, 633);
            this.pigeonList.TabIndex = 3;
            this.pigeonList.Visible = false;
            // 
            // stockList
            // 
            this.stockList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockList.Location = new System.Drawing.Point(219, 158);
            this.stockList.Name = "stockList";
            this.stockList.Size = new System.Drawing.Size(1045, 633);
            this.stockList.TabIndex = 3;
            this.stockList.Visible = false;
            // 
            // warehouseControl
            // 
            this.warehouseControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warehouseControl.Location = new System.Drawing.Point(219, 158);
            this.warehouseControl.Name = "warehouseControl";
            this.warehouseControl.Size = new System.Drawing.Size(1045, 633);
            this.warehouseControl.TabIndex = 3;
            this.warehouseControl.Visible = false;
            // 
            // placeControl
            // 
            this.placeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placeControl.Location = new System.Drawing.Point(219, 158);
            this.placeControl.Name = "placeControl";
            this.placeControl.Size = new System.Drawing.Size(1045, 633);
            this.placeControl.TabIndex = 3;
            this.placeControl.Visible = false;
            // 
            // orderControl
            // 
            this.orderControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderControl.Location = new System.Drawing.Point(219, 158);
            this.orderControl.Name = "orderControl";
            this.orderControl.Size = new System.Drawing.Size(1045, 633);
            this.orderControl.TabIndex = 3;
            this.orderControl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 788);
            this.Controls.Add(this.mainOfficeManuBar);
            this.Controls.Add(this.headerLists);
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.settingConfi);
            this.Controls.Add(this.warehouseMenuBar);
            this.Controls.Add(this.salesMenuBar);
            this.Controls.Add(this.orderControl);
            this.Controls.Add(this.reciveControl);
            this.Controls.Add(this.newProduct);
            this.Controls.Add(this.loginControl);
            this.Controls.Add(this.manufactureList);
            this.Controls.Add(this.shopList);
            this.Controls.Add(this.businesOfficeList);
            this.Controls.Add(this.empList);
            this.Controls.Add(this.unDispatched);
            this.Controls.Add(this.pigeonList);
            this.Controls.Add(this.stockList);
            this.Controls.Add(this.warehouseControl);
            this.Controls.Add(this.placeControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(910, 638);
            this.Name = "MainForm";
            this.Text = "ログイン画面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Login loginControl;
        private UserControls.SalesMenuBar salesMenuBar;
        private UserControls.WarehouseMenuBar warehouseMenuBar;
        private UserControls.ReciveAdd reciveControl;
        private UserControls.ReciveList orderControl;
        private UserControls.PlaceAnOrderList placeControl;
        private UserControls.StockList warehouseControl;
        private UserControls.PigeonList pigeonList;
        private UserControls.PlaceAnOrderList unDispatched;
        private UserControls.MainOfficeManuBar mainOfficeManuBar;
        private UserControls.EmpList empList;
        public UserControls.SalesOfficeList businesOfficeList;
        private UserControls.ShopList shopList;
        private UserControls.ManufactureList manufactureList;
        private UserControls.NewProduct newProduct;
        private UserControls.SettingConfi settingConfi;
        private UserControls.HeaderLists headerLists;
        private UserControls.StockList stockList;
        private UserControls.Header headerControl;
    }
}

