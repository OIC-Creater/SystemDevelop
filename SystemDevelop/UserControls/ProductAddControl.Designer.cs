namespace SystemDevelop.UserControls
{
    partial class ProductAddControl
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productHundlingTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.productAddButton = new System.Windows.Forms.Button();
            this.pigeonLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.sellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.manufactureID = new System.Windows.Forms.Label();
            this.settingID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cancelButton.Location = new System.Drawing.Point(573, 651);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(153, 43);
            this.cancelButton.TabIndex = 55;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // productID
            // 
            this.productID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productID.AutoSize = true;
            this.productID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productID.Location = new System.Drawing.Point(397, 95);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(117, 33);
            this.productID.TabIndex = 53;
            this.productID.Text = "id_label";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productNameTextBox.Location = new System.Drawing.Point(403, 167);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(398, 39);
            this.productNameTextBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(178, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 33);
            this.label2.TabIndex = 49;
            this.label2.Text = "メーカID";
            // 
            // productHundlingTextBox
            // 
            this.productHundlingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productHundlingTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productHundlingTextBox.Location = new System.Drawing.Point(403, 546);
            this.productHundlingTextBox.Name = "productHundlingTextBox";
            this.productHundlingTextBox.Size = new System.Drawing.Size(398, 39);
            this.productHundlingTextBox.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(178, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 33);
            this.label4.TabIndex = 46;
            this.label4.Text = "取扱い中";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(178, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 44;
            this.label1.Text = "設定ID";
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.costTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.costTextBox.Location = new System.Drawing.Point(403, 244);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(398, 39);
            this.costTextBox.TabIndex = 39;
            // 
            // productAddButton
            // 
            this.productAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.productAddButton.AutoSize = true;
            this.productAddButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productAddButton.Location = new System.Drawing.Point(751, 651);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(104, 43);
            this.productAddButton.TabIndex = 42;
            this.productAddButton.Text = "登録";
            this.productAddButton.UseVisualStyleBackColor = true;
            // 
            // pigeonLabel
            // 
            this.pigeonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonLabel.AutoSize = true;
            this.pigeonLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonLabel.Location = new System.Drawing.Point(178, 316);
            this.pigeonLabel.Name = "pigeonLabel";
            this.pigeonLabel.Size = new System.Drawing.Size(81, 33);
            this.pigeonLabel.TabIndex = 43;
            this.pigeonLabel.Text = "売価";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountLabel.Location = new System.Drawing.Point(178, 247);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(81, 33);
            this.amountLabel.TabIndex = 41;
            this.amountLabel.Text = "原価";
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productLabel.Location = new System.Drawing.Point(178, 170);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(114, 33);
            this.productLabel.TabIndex = 40;
            this.productLabel.Text = "商品名";
            // 
            // shopLabel
            // 
            this.shopLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopLabel.Location = new System.Drawing.Point(178, 95);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(112, 33);
            this.shopLabel.TabIndex = 38;
            this.shopLabel.Text = "商品ID";
            // 
            // sellingPriceTextBox
            // 
            this.sellingPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sellingPriceTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sellingPriceTextBox.Location = new System.Drawing.Point(403, 313);
            this.sellingPriceTextBox.Name = "sellingPriceTextBox";
            this.sellingPriceTextBox.Size = new System.Drawing.Size(398, 39);
            this.sellingPriceTextBox.TabIndex = 56;
            // 
            // manufactureID
            // 
            this.manufactureID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manufactureID.AutoSize = true;
            this.manufactureID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufactureID.Location = new System.Drawing.Point(397, 392);
            this.manufactureID.Name = "manufactureID";
            this.manufactureID.Size = new System.Drawing.Size(117, 33);
            this.manufactureID.TabIndex = 57;
            this.manufactureID.Text = "id_label";
            // 
            // settingID
            // 
            this.settingID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.settingID.AutoSize = true;
            this.settingID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.settingID.Location = new System.Drawing.Point(397, 471);
            this.settingID.Name = "settingID";
            this.settingID.Size = new System.Drawing.Size(117, 33);
            this.settingID.TabIndex = 58;
            this.settingID.Text = "id_label";
            // 
            // ProductAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingID);
            this.Controls.Add(this.manufactureID);
            this.Controls.Add(this.sellingPriceTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productHundlingTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.productAddButton);
            this.Controls.Add(this.pigeonLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.shopLabel);
            this.Name = "ProductAddControl";
            this.Size = new System.Drawing.Size(1033, 789);
            this.Load += new System.EventHandler(this.ProductAddControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label productID;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productHundlingTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costTextBox;
        public System.Windows.Forms.Button productAddButton;
        private System.Windows.Forms.Label pigeonLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.TextBox sellingPriceTextBox;
        private System.Windows.Forms.Label manufactureID;
        private System.Windows.Forms.Label settingID;
    }
}
