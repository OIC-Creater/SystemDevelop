namespace SystemDevelop.UserControls
{
    partial class WarehouseMenuBar
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.reciveListButton = new System.Windows.Forms.Button();
            this.orderListButton = new System.Windows.Forms.Button();
            this.stockListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reciveListButton
            // 
            this.reciveListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveListButton.BackColor = System.Drawing.SystemColors.Control;
            this.reciveListButton.FlatAppearance.BorderSize = 0;
            this.reciveListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciveListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reciveListButton.Location = new System.Drawing.Point(0, 0);
            this.reciveListButton.Name = "reciveListButton";
            this.reciveListButton.Size = new System.Drawing.Size(216, 104);
            this.reciveListButton.TabIndex = 1;
            this.reciveListButton.Text = "受注一覧";
            this.reciveListButton.UseVisualStyleBackColor = false;
            this.reciveListButton.Click += new System.EventHandler(this.reciveDetail_Click);
            // 
            // orderListButton
            // 
            this.orderListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderListButton.BackColor = System.Drawing.SystemColors.Control;
            this.orderListButton.FlatAppearance.BorderSize = 0;
            this.orderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderListButton.Location = new System.Drawing.Point(0, 104);
            this.orderListButton.Name = "orderListButton";
            this.orderListButton.Size = new System.Drawing.Size(216, 104);
            this.orderListButton.TabIndex = 2;
            this.orderListButton.Text = "発注一覧";
            this.orderListButton.UseVisualStyleBackColor = false;
            this.orderListButton.Click += new System.EventHandler(this.orderDetail_Click);
            // 
            // stockListButton
            // 
            this.stockListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockListButton.BackColor = System.Drawing.SystemColors.Control;
            this.stockListButton.FlatAppearance.BorderSize = 0;
            this.stockListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockListButton.Location = new System.Drawing.Point(0, 208);
            this.stockListButton.Name = "stockListButton";
            this.stockListButton.Size = new System.Drawing.Size(216, 104);
            this.stockListButton.TabIndex = 3;
            this.stockListButton.Text = "在庫一覧";
            this.stockListButton.UseVisualStyleBackColor = false;
            this.stockListButton.Click += new System.EventHandler(this.stock_Click);
            // 
            // WarehouseMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stockListButton);
            this.Controls.Add(this.reciveListButton);
            this.Controls.Add(this.orderListButton);
            this.Name = "WarehouseMenuBar";
            this.Size = new System.Drawing.Size(216, 689);
            this.Load += new System.EventHandler(this.WarehouseMenuBar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button reciveListButton;
        public System.Windows.Forms.Button orderListButton;
        public System.Windows.Forms.Button stockListButton;
    }
}
