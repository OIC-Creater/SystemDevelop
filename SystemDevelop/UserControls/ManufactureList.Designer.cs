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
            this.manufGridView = new System.Windows.Forms.DataGridView();
            this.manufDetailButton = new System.Windows.Forms.Button();
            this.manufListAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.manufGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // manufGridView
            // 
            this.manufGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manufGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manufGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufGridView.Location = new System.Drawing.Point(0, 0);
            this.manufGridView.Name = "manufGridView";
            this.manufGridView.RowTemplate.Height = 21;
            this.manufGridView.Size = new System.Drawing.Size(1033, 709);
            this.manufGridView.TabIndex = 0;
            this.manufGridView.TabStop = false;
            // 
            // manufDetailButton
            // 
            this.manufDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manufDetailButton.Location = new System.Drawing.Point(873, 709);
            this.manufDetailButton.Name = "manufDetailButton";
            this.manufDetailButton.Size = new System.Drawing.Size(160, 80);
            this.manufDetailButton.TabIndex = 5;
            this.manufDetailButton.Text = "詳細";
            this.manufDetailButton.UseVisualStyleBackColor = true;
            // 
            // manufListAddButton
            // 
            this.manufListAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manufListAddButton.Location = new System.Drawing.Point(707, 709);
            this.manufListAddButton.Name = "manufListAddButton";
            this.manufListAddButton.Size = new System.Drawing.Size(160, 80);
            this.manufListAddButton.TabIndex = 6;
            this.manufListAddButton.Text = "メーカ登録";
            this.manufListAddButton.UseVisualStyleBackColor = true;
            // 
            // ManufactureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manufListAddButton);
            this.Controls.Add(this.manufDetailButton);
            this.Controls.Add(this.manufGridView);
            this.Name = "ManufactureList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.manufGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button manufDetailButton;

        public System.Windows.Forms.Button manufListAddButton;

        public System.Windows.Forms.DataGridView manufGridView;

    }
}
