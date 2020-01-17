namespace SystemDevelop.UserControls
{
    partial class OrderList2
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
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.orderListAddButton = new System.Windows.Forms.Button();
            this.orderDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGridView
            // 
            this.orderGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(0, 0);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowTemplate.Height = 21;
            this.orderGridView.Size = new System.Drawing.Size(1033, 709);
            this.orderGridView.TabIndex = 0;
            // 
            // orderListAddButton
            // 
            this.orderListAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderListAddButton.Location = new System.Drawing.Point(707, 709);
            this.orderListAddButton.Name = "orderListAddButton";
            this.orderListAddButton.Size = new System.Drawing.Size(160, 80);
            this.orderListAddButton.TabIndex = 4;
            this.orderListAddButton.Text = "発注登録";
            this.orderListAddButton.UseVisualStyleBackColor = true;
            // 
            // orderDetailsButton
            // 
            this.orderDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDetailsButton.Location = new System.Drawing.Point(873, 709);
            this.orderDetailsButton.Name = "orderDetailsButton";
            this.orderDetailsButton.Size = new System.Drawing.Size(160, 80);
            this.orderDetailsButton.TabIndex = 3;
            this.orderDetailsButton.Text = "詳細";
            this.orderDetailsButton.UseVisualStyleBackColor = true;
            // 
            // OrderList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderListAddButton);
            this.Controls.Add(this.orderDetailsButton);
            this.Controls.Add(this.orderGridView);
            this.Name = "OrderList2";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button orderListAddButton;
        public System.Windows.Forms.Button orderDetailsButton;
        public System.Windows.Forms.DataGridView orderGridView;
    }
}
