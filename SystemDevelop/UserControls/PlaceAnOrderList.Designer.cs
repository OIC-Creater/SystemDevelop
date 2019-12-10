namespace SystemDevelop.UserControls
{
    partial class PlaceAnOrderList
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
            this.orderList = new System.Windows.Forms.DataGridView();
            this.place_an_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_an_order_responsible_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.place_an_order_id,
            this.place_an_order_responsible_id,
            this.date_id});
            this.orderList.Location = new System.Drawing.Point(0, 0);
            this.orderList.Name = "orderList";
            this.orderList.RowTemplate.Height = 21;
            this.orderList.Size = new System.Drawing.Size(1033, 709);
            this.orderList.TabIndex = 0;
            // 
            // place_an_order_id
            // 
            this.place_an_order_id.HeaderText = "発注ID";
            this.place_an_order_id.Name = "place_an_order_id";
            // 
            // place_an_order_responsible_id
            // 
            this.place_an_order_responsible_id.HeaderText = "発注担当者ID";
            this.place_an_order_responsible_id.Name = "place_an_order_responsible_id";
            // 
            // date_id
            // 
            this.date_id.HeaderText = "発注日付";
            this.date_id.Name = "date_id";
            // 
            // updata
            // 
            this.updata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updata.Location = new System.Drawing.Point(873, 709);
            this.updata.Name = "updata";
            this.updata.Size = new System.Drawing.Size(160, 80);
            this.updata.TabIndex = 1;
            this.updata.Text = "更新";
            this.updata.UseVisualStyleBackColor = true;
            // 
            // PlaceAnOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updata);
            this.Controls.Add(this.orderList);
            this.Name = "PlaceAnOrderList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_an_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_an_order_responsible_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_id;
        private System.Windows.Forms.Button updata;
    }
}
