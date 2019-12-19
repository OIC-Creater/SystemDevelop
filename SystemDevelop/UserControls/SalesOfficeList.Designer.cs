namespace SystemDevelop.UserControls
{
    partial class SalesOfficeList
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
            this.salesOfficeGridView = new System.Windows.Forms.DataGridView();
            this.salesOfficeDetailButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesOfficeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesOfficeGridView
            // 
            this.salesOfficeGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesOfficeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesOfficeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesOfficeGridView.Location = new System.Drawing.Point(0, 0);
            this.salesOfficeGridView.Name = "salesOfficeGridView";
            this.salesOfficeGridView.RowTemplate.Height = 21;
            this.salesOfficeGridView.Size = new System.Drawing.Size(1033, 709);
            this.salesOfficeGridView.TabIndex = 0;
            this.salesOfficeGridView.TabStop = false;
            // 
            // salesOfficeDetailButton
            // 
            this.salesOfficeDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salesOfficeDetailButton.Location = new System.Drawing.Point(873, 709);
            this.salesOfficeDetailButton.Name = "salesOfficeDetailButton";
            this.salesOfficeDetailButton.Size = new System.Drawing.Size(160, 80);
            this.salesOfficeDetailButton.TabIndex = 2;
            this.salesOfficeDetailButton.Text = "詳細";
            this.salesOfficeDetailButton.UseVisualStyleBackColor = true;
            // 
            // SalesOfficeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salesOfficeDetailButton);
            this.Controls.Add(this.salesOfficeGridView);
            this.Name = "SalesOfficeList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.salesOfficeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button salesOfficeDetailButton;
        public System.Windows.Forms.DataGridView salesOfficeGridView;
    }
}
