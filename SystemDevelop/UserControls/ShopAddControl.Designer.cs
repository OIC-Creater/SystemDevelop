namespace SystemDevelop.UserControls
{
    partial class ShopAddControl
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
            this.shopID = new System.Windows.Forms.Label();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shopPhoneTextBox = new System.Windows.Forms.TextBox();
            this.shopAddButton = new System.Windows.Forms.Button();
            this.pigeonLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.shopAddressTextBox = new System.Windows.Forms.TextBox();
            this.shopFaxTextBox = new System.Windows.Forms.TextBox();
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
            // shopID
            // 
            this.shopID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shopID.AutoSize = true;
            this.shopID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopID.Location = new System.Drawing.Point(397, 95);
            this.shopID.Name = "shopID";
            this.shopID.Size = new System.Drawing.Size(117, 33);
            this.shopID.TabIndex = 53;
            this.shopID.Text = "id_label";
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shopNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopNameTextBox.Location = new System.Drawing.Point(403, 187);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(398, 39);
            this.shopNameTextBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(178, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 33);
            this.label2.TabIndex = 49;
            this.label2.Text = "FAX番号";
            // 
            // shopPhoneTextBox
            // 
            this.shopPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shopPhoneTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopPhoneTextBox.Location = new System.Drawing.Point(403, 291);
            this.shopPhoneTextBox.Name = "shopPhoneTextBox";
            this.shopPhoneTextBox.Size = new System.Drawing.Size(398, 39);
            this.shopPhoneTextBox.TabIndex = 39;
            // 
            // shopAddButton
            // 
            this.shopAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shopAddButton.AutoSize = true;
            this.shopAddButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopAddButton.Location = new System.Drawing.Point(751, 651);
            this.shopAddButton.Name = "shopAddButton";
            this.shopAddButton.Size = new System.Drawing.Size(104, 43);
            this.shopAddButton.TabIndex = 42;
            this.shopAddButton.Text = "登録";
            this.shopAddButton.UseVisualStyleBackColor = true;
            // 
            // pigeonLabel
            // 
            this.pigeonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonLabel.AutoSize = true;
            this.pigeonLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonLabel.Location = new System.Drawing.Point(178, 403);
            this.pigeonLabel.Name = "pigeonLabel";
            this.pigeonLabel.Size = new System.Drawing.Size(81, 33);
            this.pigeonLabel.TabIndex = 43;
            this.pigeonLabel.Text = "住所";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountLabel.Location = new System.Drawing.Point(178, 294);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(147, 33);
            this.amountLabel.TabIndex = 41;
            this.amountLabel.Text = "電話番号";
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productLabel.Location = new System.Drawing.Point(178, 190);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(137, 33);
            this.productLabel.TabIndex = 40;
            this.productLabel.Text = "ショップ名";
            // 
            // shopLabel
            // 
            this.shopLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopLabel.Location = new System.Drawing.Point(178, 95);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(135, 33);
            this.shopLabel.TabIndex = 38;
            this.shopLabel.Text = "ショップID";
            // 
            // shopAddressTextBox
            // 
            this.shopAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shopAddressTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopAddressTextBox.Location = new System.Drawing.Point(403, 400);
            this.shopAddressTextBox.Name = "shopAddressTextBox";
            this.shopAddressTextBox.Size = new System.Drawing.Size(398, 39);
            this.shopAddressTextBox.TabIndex = 57;
            // 
            // shopFaxTextBox
            // 
            this.shopFaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shopFaxTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopFaxTextBox.Location = new System.Drawing.Point(403, 517);
            this.shopFaxTextBox.Name = "shopFaxTextBox";
            this.shopFaxTextBox.Size = new System.Drawing.Size(398, 39);
            this.shopFaxTextBox.TabIndex = 56;
            // 
            // ShopAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shopAddressTextBox);
            this.Controls.Add(this.shopFaxTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.shopID);
            this.Controls.Add(this.shopNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shopPhoneTextBox);
            this.Controls.Add(this.shopAddButton);
            this.Controls.Add(this.pigeonLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.shopLabel);
            this.Name = "ShopAddControl";
            this.Size = new System.Drawing.Size(1033, 789);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label shopID;
        private System.Windows.Forms.TextBox shopNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shopPhoneTextBox;
        public System.Windows.Forms.Button shopAddButton;
        private System.Windows.Forms.Label pigeonLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.TextBox shopAddressTextBox;
        private System.Windows.Forms.TextBox shopFaxTextBox;
    }
}
