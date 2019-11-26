namespace SystemDevelop.UserControll
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
            this.order = new System.Windows.Forms.Button();
            this.reciveDetail = new System.Windows.Forms.Button();
            this.orderDetail = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order.BackColor = System.Drawing.SystemColors.Control;
            this.order.FlatAppearance.BorderSize = 0;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.order.Location = new System.Drawing.Point(0, 208);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(216, 104);
            this.order.TabIndex = 6;
            this.order.Text = "発注";
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // reciveDetail
            // 
            this.reciveDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveDetail.BackColor = System.Drawing.SystemColors.Control;
            this.reciveDetail.FlatAppearance.BorderSize = 0;
            this.reciveDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciveDetail.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reciveDetail.Location = new System.Drawing.Point(0, 0);
            this.reciveDetail.Name = "reciveDetail";
            this.reciveDetail.Size = new System.Drawing.Size(216, 104);
            this.reciveDetail.TabIndex = 4;
            this.reciveDetail.Text = "受注一覧";
            this.reciveDetail.UseVisualStyleBackColor = false;
            this.reciveDetail.Click += new System.EventHandler(this.reciveDetail_Click);
            // 
            // orderDetail
            // 
            this.orderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDetail.BackColor = System.Drawing.SystemColors.Control;
            this.orderDetail.FlatAppearance.BorderSize = 0;
            this.orderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDetail.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderDetail.Location = new System.Drawing.Point(0, 104);
            this.orderDetail.Name = "orderDetail";
            this.orderDetail.Size = new System.Drawing.Size(216, 104);
            this.orderDetail.TabIndex = 5;
            this.orderDetail.Text = "発注一覧";
            this.orderDetail.UseVisualStyleBackColor = false;
            this.orderDetail.Click += new System.EventHandler(this.orderDetail_Click);
            // 
            // stock
            // 
            this.stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock.BackColor = System.Drawing.SystemColors.Control;
            this.stock.FlatAppearance.BorderSize = 0;
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stock.Location = new System.Drawing.Point(0, 312);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(216, 104);
            this.stock.TabIndex = 7;
            this.stock.Text = "在庫一覧";
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.stock_Click);
            // 
            // WarehouseMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stock);
            this.Controls.Add(this.order);
            this.Controls.Add(this.reciveDetail);
            this.Controls.Add(this.orderDetail);
            this.Name = "WarehouseMenuBar";
            this.Size = new System.Drawing.Size(216, 689);
            this.Load += new System.EventHandler(this.WarehouseMenuBar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button order;
        public System.Windows.Forms.Button reciveDetail;
        public System.Windows.Forms.Button orderDetail;
        public System.Windows.Forms.Button stock;
    }
}
