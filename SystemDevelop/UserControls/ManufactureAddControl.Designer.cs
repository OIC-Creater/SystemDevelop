namespace SystemDevelop.UserControls
{
    partial class ManufactureAddControl
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
            this.manufacturerAddID = new System.Windows.Forms.Label();
            this.manufacturerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.manufacturerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.manufactureAddButton = new System.Windows.Forms.Button();
            this.pigeonLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.manufacturerFaxTextBox = new System.Windows.Forms.TextBox();
            this.manufactureAddressTextBox = new System.Windows.Forms.TextBox();
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
            // manufacturerAddID
            // 
            this.manufacturerAddID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manufacturerAddID.AutoSize = true;
            this.manufacturerAddID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufacturerAddID.Location = new System.Drawing.Point(397, 95);
            this.manufacturerAddID.Name = "manufacturerAddID";
            this.manufacturerAddID.Size = new System.Drawing.Size(117, 33);
            this.manufacturerAddID.TabIndex = 53;
            this.manufacturerAddID.Text = "id_label";
            // 
            // manufacturerNameTextBox
            // 
            this.manufacturerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manufacturerNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufacturerNameTextBox.Location = new System.Drawing.Point(403, 195);
            this.manufacturerNameTextBox.Name = "manufacturerNameTextBox";
            this.manufacturerNameTextBox.Size = new System.Drawing.Size(398, 39);
            this.manufacturerNameTextBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(178, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 49;
            this.label2.Text = "住所";
            // 
            // manufacturerPhoneTextBox
            // 
            this.manufacturerPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manufacturerPhoneTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufacturerPhoneTextBox.Location = new System.Drawing.Point(403, 307);
            this.manufacturerPhoneTextBox.Name = "manufacturerPhoneTextBox";
            this.manufacturerPhoneTextBox.Size = new System.Drawing.Size(398, 39);
            this.manufacturerPhoneTextBox.TabIndex = 39;
            // 
            // manufactureAddButton
            // 
            this.manufactureAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.manufactureAddButton.AutoSize = true;
            this.manufactureAddButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufactureAddButton.Location = new System.Drawing.Point(751, 651);
            this.manufactureAddButton.Name = "manufactureAddButton";
            this.manufactureAddButton.Size = new System.Drawing.Size(104, 43);
            this.manufactureAddButton.TabIndex = 42;
            this.manufactureAddButton.Text = "登録";
            this.manufactureAddButton.UseVisualStyleBackColor = true;
            // 
            // pigeonLabel
            // 
            this.pigeonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonLabel.AutoSize = true;
            this.pigeonLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonLabel.Location = new System.Drawing.Point(178, 430);
            this.pigeonLabel.Name = "pigeonLabel";
            this.pigeonLabel.Size = new System.Drawing.Size(141, 33);
            this.pigeonLabel.TabIndex = 43;
            this.pigeonLabel.Text = "FAX番号";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountLabel.Location = new System.Drawing.Point(178, 310);
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
            this.productLabel.Location = new System.Drawing.Point(178, 198);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(122, 33);
            this.productLabel.TabIndex = 40;
            this.productLabel.Text = "メーカ名";
            // 
            // shopLabel
            // 
            this.shopLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopLabel.Location = new System.Drawing.Point(178, 95);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(120, 33);
            this.shopLabel.TabIndex = 38;
            this.shopLabel.Text = "メーカID";
            // 
            // manufacturerFaxTextBox
            // 
            this.manufacturerFaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manufacturerFaxTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufacturerFaxTextBox.Location = new System.Drawing.Point(403, 427);
            this.manufacturerFaxTextBox.Name = "manufacturerFaxTextBox";
            this.manufacturerFaxTextBox.Size = new System.Drawing.Size(398, 39);
            this.manufacturerFaxTextBox.TabIndex = 57;
            // 
            // manufactureAddressTextBox
            // 
            this.manufactureAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manufactureAddressTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufactureAddressTextBox.Location = new System.Drawing.Point(403, 537);
            this.manufactureAddressTextBox.Name = "manufactureAddressTextBox";
            this.manufactureAddressTextBox.Size = new System.Drawing.Size(398, 39);
            this.manufactureAddressTextBox.TabIndex = 56;
            // 
            // ManufactureAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manufacturerFaxTextBox);
            this.Controls.Add(this.manufactureAddressTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.manufacturerAddID);
            this.Controls.Add(this.manufacturerNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manufacturerPhoneTextBox);
            this.Controls.Add(this.manufactureAddButton);
            this.Controls.Add(this.pigeonLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.shopLabel);
            this.Name = "ManufactureAddControl";
            this.Size = new System.Drawing.Size(1033, 789);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label manufacturerAddID;
        private System.Windows.Forms.TextBox manufacturerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox manufacturerPhoneTextBox;
        public System.Windows.Forms.Button manufactureAddButton;
        private System.Windows.Forms.Label pigeonLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.TextBox manufacturerFaxTextBox;
        private System.Windows.Forms.TextBox manufactureAddressTextBox;
    }
}
