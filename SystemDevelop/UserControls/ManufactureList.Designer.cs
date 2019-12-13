namespace SystemDevelop.UserControls
{
    partial class ManufactureList
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
            this.manufacturer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.manufacturer_id,
            this.manufacturer_name,
            this.manufacturer_phone,
            this.manufacturer_address,
            this.manufacturer_fax});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 709);
            this.dataGridView1.TabIndex = 0;
            // 
            // manufacturer_id
            // 
            this.manufacturer_id.HeaderText = "メーカID";
            this.manufacturer_id.Name = "manufacturer_id";
            // 
            // manufacturer_name
            // 
            this.manufacturer_name.HeaderText = "メーカ名";
            this.manufacturer_name.Name = "manufacturer_name";
            // 
            // manufacturer_phone
            // 
            this.manufacturer_phone.HeaderText = "電話番号";
            this.manufacturer_phone.Name = "manufacturer_phone";
            // 
            // manufacturer_address
            // 
            this.manufacturer_address.HeaderText = "住所";
            this.manufacturer_address.Name = "manufacturer_address";
            // 
            // manufacturer_fax
            // 
            this.manufacturer_fax.HeaderText = "FAX番号";
            this.manufacturer_fax.Name = "manufacturer_fax";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(873, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManufactureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManufactureList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_fax;
    }
}
