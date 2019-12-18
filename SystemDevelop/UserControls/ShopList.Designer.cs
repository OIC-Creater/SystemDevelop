namespace SystemDevelop.UserControls
{
    partial class ShopList
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
            this.shopGridView = new System.Windows.Forms.DataGridView();
            this.shopDetailButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shopGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shopGridView
            // 
            this.shopGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shopGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopGridView.Location = new System.Drawing.Point(0, 0);
            this.shopGridView.Name = "shopGridView";
            this.shopGridView.RowTemplate.Height = 21;
            this.shopGridView.Size = new System.Drawing.Size(1033, 709);
            this.shopGridView.TabIndex = 0;
            this.shopGridView.TabStop = false;
            // 
            // shopDetailButton
            // 
            this.shopDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shopDetailButton.Location = new System.Drawing.Point(873, 709);
            this.shopDetailButton.Name = "shopDetailButton";
            this.shopDetailButton.Size = new System.Drawing.Size(160, 80);
            this.shopDetailButton.TabIndex = 1;
            this.shopDetailButton.Text = "詳細";
            this.shopDetailButton.UseVisualStyleBackColor = true;
            // 
            // ShopList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shopDetailButton);
            this.Controls.Add(this.shopGridView);
            this.Name = "ShopList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.shopGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shopGridView;
        public System.Windows.Forms.Button shopDetailButton;
    }
}
