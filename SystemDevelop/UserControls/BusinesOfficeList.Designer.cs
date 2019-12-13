namespace SystemDevelop.UserControls
{
    partial class BusinesOfficeList
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
            this.bussines_office_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busines_office_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busines_office_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busines_office_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busines_office_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.bussines_office_id,
            this.busines_office_name,
            this.busines_office_phone,
            this.busines_office_address,
            this.busines_office_fax});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 709);
            this.dataGridView1.TabIndex = 0;
            // 
            // bussines_office_id
            // 
            this.bussines_office_id.HeaderText = "営業所ID";
            this.bussines_office_id.Name = "bussines_office_id";
            // 
            // busines_office_name
            // 
            this.busines_office_name.HeaderText = "営業所名";
            this.busines_office_name.Name = "busines_office_name";
            // 
            // busines_office_phone
            // 
            this.busines_office_phone.HeaderText = "電話番号";
            this.busines_office_phone.Name = "busines_office_phone";
            // 
            // busines_office_address
            // 
            this.busines_office_address.HeaderText = "住所";
            this.busines_office_address.Name = "busines_office_address";
            // 
            // busines_office_fax
            // 
            this.busines_office_fax.HeaderText = "FAX番号";
            this.busines_office_fax.Name = "busines_office_fax";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(873, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BusinesOfficeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BusinesOfficeList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bussines_office_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn busines_office_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn busines_office_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn busines_office_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn busines_office_fax;
        private System.Windows.Forms.Button button1;
    }
}
