namespace SystemDevelop.UserControls
{
    partial class Pigeon
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
            this.pigeon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pigeon_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.public_key_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pigeon_status_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pigeon_id,
            this.pigeon_name,
            this.public_key_id,
            this.pigeon_status_id});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 709);
            this.dataGridView1.TabIndex = 0;
            // 
            // pigeon_id
            // 
            this.pigeon_id.HeaderText = "ハトID";
            this.pigeon_id.Name = "pigeon_id";
            // 
            // pigeon_name
            // 
            this.pigeon_name.HeaderText = "ハト名";
            this.pigeon_name.Name = "pigeon_name";
            // 
            // public_key_id
            // 
            this.public_key_id.HeaderText = "公開鍵";
            this.public_key_id.Name = "public_key_id";
            // 
            // pigeon_status_id
            // 
            this.pigeon_status_id.HeaderText = "ステータスID";
            this.pigeon_status_id.Name = "pigeon_status_id";
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
            // Pigeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pigeon";
            this.Size = new System.Drawing.Size(1033, 789);
            this.Load += new System.EventHandler(this.Pigeon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pigeon_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pigeon_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn public_key_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pigeon_status_id;
        public System.Windows.Forms.Button updata;
    }
}
