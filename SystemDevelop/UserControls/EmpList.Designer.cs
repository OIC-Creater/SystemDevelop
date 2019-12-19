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
            this.empGridView = new System.Windows.Forms.DataGridView();
            this.empDetailButton = new System.Windows.Forms.Button();
            this.empListAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // empGridView
            // 
            this.empGridView.AllowUserToAddRows = false;
            this.empGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.empGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGridView.Location = new System.Drawing.Point(0, 0);
            this.empGridView.MultiSelect = false;
            this.empGridView.Name = "empGridView";
            this.empGridView.ReadOnly = true;
            this.empGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.empGridView.RowTemplate.Height = 50;
            this.empGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empGridView.Size = new System.Drawing.Size(1033, 709);
            this.empGridView.TabIndex = 0;
            this.empGridView.TabStop = false;
            // 
            // empDetailButton
            // 
            this.empDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.empDetailButton.Location = new System.Drawing.Point(873, 709);
            this.empDetailButton.Name = "empDetailButton";
            this.empDetailButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.empDetailButton.Size = new System.Drawing.Size(160, 80);
            this.empDetailButton.TabIndex = 2;
            this.empDetailButton.Text = "詳細";
            this.empDetailButton.UseVisualStyleBackColor = true;
            // 
            // empListAddButton
            // 
            this.empListAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.empListAddButton.Location = new System.Drawing.Point(707, 709);
            this.empListAddButton.Name = "empListAddButton";
            this.empListAddButton.Size = new System.Drawing.Size(160, 80);
            this.empListAddButton.TabIndex = 3;
            this.empListAddButton.Text = "社員登録";
            this.empListAddButton.UseVisualStyleBackColor = true;
            // 
            // EmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.empListAddButton);
            this.Controls.Add(this.empDetailButton);
            this.Controls.Add(this.empGridView);
            this.Name = "EmpList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.empGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button empDetailButton;

        public System.Windows.Forms.Button empListAddButton;

        public System.Windows.Forms.DataGridView empGridView;

    }
}
