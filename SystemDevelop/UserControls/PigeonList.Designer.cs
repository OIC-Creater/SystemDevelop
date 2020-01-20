namespace SystemDevelop.UserControls
{
    partial class PigeonList
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
            this.pigeonGridView = new System.Windows.Forms.DataGridView();
            this.pigeonDetailButton = new System.Windows.Forms.Button();
            this.pigeonListAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pigeonGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pigeonGridView
            // 
            this.pigeonGridView.AllowUserToAddRows = false;
            this.pigeonGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pigeonGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.pigeonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pigeonGridView.Location = new System.Drawing.Point(0, 0);
            this.pigeonGridView.MultiSelect = false;
            this.pigeonGridView.Name = "pigeonGridView";
            this.pigeonGridView.ReadOnly = true;
            this.pigeonGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.pigeonGridView.RowTemplate.Height = 21;
            this.pigeonGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pigeonGridView.Size = new System.Drawing.Size(1033, 709);
            this.pigeonGridView.TabIndex = 0;
            this.pigeonGridView.TabStop = false;
            // 
            // pigeonDetailButton
            // 
            this.pigeonDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonDetailButton.Location = new System.Drawing.Point(873, 709);
            this.pigeonDetailButton.Name = "pigeonDetailButton";
            this.pigeonDetailButton.Size = new System.Drawing.Size(160, 80);
            this.pigeonDetailButton.TabIndex = 1;
            this.pigeonDetailButton.Text = "詳細";
            this.pigeonDetailButton.UseVisualStyleBackColor = true;
            // 
            // pigeonListAddButton
            // 
            this.pigeonListAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonListAddButton.Location = new System.Drawing.Point(707, 709);
            this.pigeonListAddButton.Name = "pigeonListAddButton";
            this.pigeonListAddButton.Size = new System.Drawing.Size(160, 80);
            this.pigeonListAddButton.TabIndex = 2;
            this.pigeonListAddButton.Text = "ハト登録";
            this.pigeonListAddButton.UseVisualStyleBackColor = true;
            // 
            // PigeonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pigeonListAddButton);
            this.Controls.Add(this.pigeonDetailButton);
            this.Controls.Add(this.pigeonGridView);
            this.Name = "PigeonList";
            this.Size = new System.Drawing.Size(1033, 789);
            this.Load += new System.EventHandler(this.Pigeon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pigeonGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button pigeonDetailButton;
        public System.Windows.Forms.DataGridView pigeonGridView;
        public System.Windows.Forms.Button pigeonListAddButton;
    }
}
