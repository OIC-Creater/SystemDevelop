namespace SystemDevelop.UserControls
{
    partial class EmpList
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
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_katakana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affiliation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pigeon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_employment = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.employee_id,
            this.employee_name,
            this.employee_katakana,
            this.affiliation_id,
            this.employee_password,
            this.phone_number,
            this.pigeon_id,
            this.employee_employment});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 709);
            this.dataGridView1.TabIndex = 0;
            // 
            // employee_id
            // 
            this.employee_id.HeaderText = "社員ID";
            this.employee_id.Name = "employee_id";
            // 
            // employee_name
            // 
            this.employee_name.HeaderText = "社員名";
            this.employee_name.Name = "employee_name";
            // 
            // employee_katakana
            // 
            this.employee_katakana.HeaderText = "名前カタカナ";
            this.employee_katakana.Name = "employee_katakana";
            // 
            // affiliation_id
            // 
            this.affiliation_id.HeaderText = "所属ID";
            this.affiliation_id.Name = "affiliation_id";
            // 
            // employee_password
            // 
            this.employee_password.HeaderText = "パスワード";
            this.employee_password.Name = "employee_password";
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "電話番号";
            this.phone_number.Name = "phone_number";
            // 
            // pigeon_id
            // 
            this.pigeon_id.HeaderText = "ハトID";
            this.pigeon_id.Name = "pigeon_id";
            // 
            // employee_employment
            // 
            this.employee_employment.HeaderText = "雇用中";
            this.employee_employment.Name = "employee_employment";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(873, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmpList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_katakana;
        private System.Windows.Forms.DataGridViewTextBoxColumn affiliation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn pigeon_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_employment;
        private System.Windows.Forms.Button button1;
    }
}
