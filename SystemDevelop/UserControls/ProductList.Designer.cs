namespace SystemDevelop.UserControls
{
    partial class ProductList
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
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.productListAddButton = new System.Windows.Forms.Button();
            this.productDetailButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(0, 0);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 21;
            this.productGridView.Size = new System.Drawing.Size(1033, 709);
            this.productGridView.TabIndex = 1;
            this.productGridView.TabStop = false;
            // 
            // productListAddButton
            // 
            this.productListAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productListAddButton.Location = new System.Drawing.Point(707, 709);
            this.productListAddButton.Name = "productListAddButton";
            this.productListAddButton.Size = new System.Drawing.Size(160, 80);
            this.productListAddButton.TabIndex = 8;
            this.productListAddButton.Text = "商品登録";
            this.productListAddButton.UseVisualStyleBackColor = true;
            // 
            // productDetailButton
            // 
            this.productDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productDetailButton.Location = new System.Drawing.Point(873, 709);
            this.productDetailButton.Name = "productDetailButton";
            this.productDetailButton.Size = new System.Drawing.Size(160, 80);
            this.productDetailButton.TabIndex = 7;
            this.productDetailButton.Text = "詳細";
            this.productDetailButton.UseVisualStyleBackColor = true;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productListAddButton);
            this.Controls.Add(this.productDetailButton);
            this.Controls.Add(this.productGridView);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        public System.Windows.Forms.Button productListAddButton;
        public System.Windows.Forms.Button productDetailButton;
    }
}
