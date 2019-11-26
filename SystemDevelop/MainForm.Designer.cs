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
            this.salesMenuBar = new SystemDevelop.UserControll.SalesMenuBar();
            this.headerControl = new SystemDevelop.Header();
            this.loginControl = new SystemDevelop.UserControll.Login();
            this.warehouseMenuBar = new SystemDevelop.UserControll.WarehouseMenuBar();
            this.SuspendLayout();
            // 
            // salesMenuBar
            // 
            this.salesMenuBar.Location = new System.Drawing.Point(0, 81);
            this.salesMenuBar.Name = "salesMenuBar";
            this.salesMenuBar.Size = new System.Drawing.Size(231, 789);
            this.salesMenuBar.TabIndex = 13;
            // 
            // headerControl
            // 
            this.headerControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerControl.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.headerControl.Location = new System.Drawing.Point(0, 1);
            this.headerControl.Name = "headerControl";
            this.headerControl.Size = new System.Drawing.Size(1264, 80);
            this.headerControl.TabIndex = 11;
            // 
            // loginControl
            // 
            this.loginControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginControl.Location = new System.Drawing.Point(0, 1);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(1264, 869);
            this.loginControl.TabIndex = 12;
            // 
            // warehouseMenuBar
            // 
            this.warehouseMenuBar.Location = new System.Drawing.Point(0, 81);
            this.warehouseMenuBar.Name = "warehouseMenuBar";
            this.warehouseMenuBar.Size = new System.Drawing.Size(231, 789);
            this.warehouseMenuBar.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 871);
            this.Controls.Add(this.warehouseMenuBar);
            this.Controls.Add(this.salesMenuBar);
            this.Controls.Add(this.headerControl);
            this.Controls.Add(this.loginControl);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(910, 638);
            this.Name = "MainForm";
            this.Text = "ログイン画面";
            this.ResumeLayout(false);

        }

        #endregion

        private Header headerControl;
        private UserControll.Login loginControl;
        private UserControll.SalesMenuBar salesMenuBar;
        private UserControll.WarehouseMenuBar warehouseMenuBar;
    }
}

