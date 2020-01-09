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
            this.orderID = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.TextBox();
            this.orderAddButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.empResponsibleID = new System.Windows.Forms.Label();
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
            // orderID
            // 
            this.orderID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderID.AutoSize = true;
            this.orderID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderID.Location = new System.Drawing.Point(397, 123);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(117, 33);
            this.orderID.TabIndex = 53;
            this.orderID.Text = "id_label";
            // 
            // orderDate
            // 
            this.orderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDate.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderDate.Location = new System.Drawing.Point(403, 457);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(398, 39);
            this.orderDate.TabIndex = 39;
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
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountLabel.Location = new System.Drawing.Point(178, 460);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(147, 33);
            this.amountLabel.TabIndex = 41;
            this.amountLabel.Text = "発注日時";
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productLabel.Location = new System.Drawing.Point(178, 302);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(178, 33);
            this.productLabel.TabIndex = 40;
            this.productLabel.Text = "発注担当ID";
            // 
            // shopLabel
            // 
            this.shopLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopLabel.Location = new System.Drawing.Point(178, 123);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(112, 33);
            this.shopLabel.TabIndex = 38;
            this.shopLabel.Text = "発注ID";
            // 
            // empResponsibleID
            // 
            this.empResponsibleID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.empResponsibleID.AutoSize = true;
            this.empResponsibleID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empResponsibleID.Location = new System.Drawing.Point(397, 302);
            this.empResponsibleID.Name = "empResponsibleID";
            this.empResponsibleID.Size = new System.Drawing.Size(117, 33);
            this.empResponsibleID.TabIndex = 56;
            this.empResponsibleID.Text = "id_label";
            // 
            // OrderAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.empResponsibleID);
            this.Controls.Add(this.orderCancelButton);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.orderAddButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.shopLabel);
            this.Name = "OrderAddControl";
            this.Size = new System.Drawing.Size(1033, 789);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button orderCancelButton;
        private System.Windows.Forms.Label orderID;
        private System.Windows.Forms.TextBox orderDate;
        public System.Windows.Forms.Button orderAddButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label empResponsibleID;
    }
}
