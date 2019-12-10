namespace SystemDevelop.UserControls
{
    partial class OrderList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.get_an_order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_office_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_office_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_responsible_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pigeon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepit_check_id = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.updata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.get_an_order_id,
            this.business_office_id,
            this.sales_office_id,
            this.date_id,
            this.staff_responsible_id,
            this.pigeon_id,
            this.recepit_check_id});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 709);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // get_an_order_id
            // 
            this.get_an_order_id.FillWeight = 99.69697F;
            this.get_an_order_id.HeaderText = "受注ID";
            this.get_an_order_id.Name = "get_an_order_id";
            // 
            // business_office_id
            // 
            this.business_office_id.FillWeight = 100.4488F;
            this.business_office_id.HeaderText = "営業所ID";
            this.business_office_id.Name = "business_office_id";
            // 
            // sales_office_id
            // 
            this.sales_office_id.FillWeight = 99.67876F;
            this.sales_office_id.HeaderText = "ショップID";
            this.sales_office_id.Name = "sales_office_id";
            // 
            // date_id
            // 
            this.date_id.FillWeight = 100.4331F;
            this.date_id.HeaderText = "受注日";
            this.date_id.Name = "date_id";
            // 
            // staff_responsible_id
            // 
            this.staff_responsible_id.FillWeight = 99.66537F;
            this.staff_responsible_id.HeaderText = "担当者ID";
            this.staff_responsible_id.Name = "staff_responsible_id";
            // 
            // pigeon_id
            // 
            this.pigeon_id.FillWeight = 100.4215F;
            this.pigeon_id.HeaderText = "ハトID";
            this.pigeon_id.Name = "pigeon_id";
            // 
            // recepit_check_id
            // 
            this.recepit_check_id.FillWeight = 99.65556F;
            this.recepit_check_id.HeaderText = "受領チェック";
            this.recepit_check_id.Name = "recepit_check_id";
            this.recepit_check_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recepit_check_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn get_an_order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_office_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_office_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_responsible_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pigeon_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recepit_check_id;
        private System.Windows.Forms.Button updata;
    }
}
