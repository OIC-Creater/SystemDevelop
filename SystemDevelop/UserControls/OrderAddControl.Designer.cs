namespace SystemDevelop.UserControls
{
    partial class OrderAddControl
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
            this.orderCancelButton = new System.Windows.Forms.Button();
            this.orderId = new System.Windows.Forms.Label();
            this.orderAddButton = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // orderCancelButton
            // 
            this.orderCancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderCancelButton.AutoSize = true;
            this.orderCancelButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderCancelButton.Location = new System.Drawing.Point(573, 651);
            this.orderCancelButton.Name = "orderCancelButton";
            this.orderCancelButton.Size = new System.Drawing.Size(153, 43);
            this.orderCancelButton.TabIndex = 55;
            this.orderCancelButton.Text = "キャンセル";
            this.orderCancelButton.UseVisualStyleBackColor = true;
            // 
            // orderId
            // 
            this.orderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderId.AutoSize = true;
            this.orderId.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderId.Location = new System.Drawing.Point(468, 143);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(117, 33);
            this.orderId.TabIndex = 53;
            this.orderId.Text = "id_label";
            // 
            // orderAddButton
            // 
            this.orderAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderAddButton.AutoSize = true;
            this.orderAddButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderAddButton.Location = new System.Drawing.Point(751, 651);
            this.orderAddButton.Name = "orderAddButton";
            this.orderAddButton.Size = new System.Drawing.Size(104, 43);
            this.orderAddButton.TabIndex = 42;
            this.orderAddButton.Text = "登録";
            this.orderAddButton.UseVisualStyleBackColor = true;
            this.orderAddButton.Click += new System.EventHandler(this.orderAddButton_Click);
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productLabel.Location = new System.Drawing.Point(331, 431);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(81, 33);
            this.productLabel.TabIndex = 40;
            this.productLabel.Text = "商品";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderIdLabel.Location = new System.Drawing.Point(331, 143);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(112, 33);
            this.orderIdLabel.TabIndex = 38;
            this.orderIdLabel.Text = "発注ID";
            // 
            // productComboBox
            // 
            this.productComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productComboBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(474, 428);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(336, 41);
            this.productComboBox.TabIndex = 56;
            // 
            // OrderAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.orderCancelButton);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.orderAddButton);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Name = "OrderAddControl";
            this.Size = new System.Drawing.Size(1033, 789);
            this.Load += new System.EventHandler(this.OrderAddControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button orderCancelButton;
        public System.Windows.Forms.Button orderAddButton;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label orderIdLabel;
        public System.Windows.Forms.Label orderId;
        public System.Windows.Forms.ComboBox productComboBox;
    }
}
