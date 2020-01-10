namespace SystemDevelop.UserControls
{
    partial class ShopDetails
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
            this.shopCancelButton = new System.Windows.Forms.Button();
            this.shopUpdataButton = new System.Windows.Forms.Button();
            this.shopFax = new System.Windows.Forms.TextBox();
            this.shopAddress = new System.Windows.Forms.TextBox();
            this.shopPhone = new System.Windows.Forms.TextBox();
            this.shopID = new System.Windows.Forms.Label();
            this.shopName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shopCancelButton
            // 
            this.shopCancelButton.Location = new System.Drawing.Point(314, 580);
            this.shopCancelButton.Name = "shopCancelButton";
            this.shopCancelButton.Size = new System.Drawing.Size(170, 60);
            this.shopCancelButton.TabIndex = 6;
            this.shopCancelButton.Text = "キャンセル";
            this.shopCancelButton.UseVisualStyleBackColor = true;
            // 
            // shopUpdataButton
            // 
            this.shopUpdataButton.Location = new System.Drawing.Point(551, 580);
            this.shopUpdataButton.Name = "shopUpdataButton";
            this.shopUpdataButton.Size = new System.Drawing.Size(170, 60);
            this.shopUpdataButton.TabIndex = 5;
            this.shopUpdataButton.Text = "更新";
            this.shopUpdataButton.UseVisualStyleBackColor = true;
            // 
            // shopFax
            // 
            this.shopFax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopFax.Location = new System.Drawing.Point(501, 471);
            this.shopFax.Name = "shopFax";
            this.shopFax.Size = new System.Drawing.Size(340, 31);
            this.shopFax.TabIndex = 4;
            // 
            // shopAddress
            // 
            this.shopAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopAddress.Location = new System.Drawing.Point(502, 362);
            this.shopAddress.Name = "shopAddress";
            this.shopAddress.Size = new System.Drawing.Size(340, 31);
            this.shopAddress.TabIndex = 3;
            // 
            // shopPhone
            // 
            this.shopPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopPhone.Location = new System.Drawing.Point(501, 263);
            this.shopPhone.Name = "shopPhone";
            this.shopPhone.Size = new System.Drawing.Size(340, 31);
            this.shopPhone.TabIndex = 2;
            // 
            // shopID
            // 
            this.shopID.AutoSize = true;
            this.shopID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopID.Location = new System.Drawing.Point(624, 67);
            this.shopID.Name = "shopID";
            this.shopID.Size = new System.Drawing.Size(79, 24);
            this.shopID.TabIndex = 36;
            this.shopID.Text = "id_label";
            // 
            // shopName
            // 
            this.shopName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopName.Location = new System.Drawing.Point(502, 159);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(340, 31);
            this.shopName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(175, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "FAX番号\t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(175, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "住所\t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(175, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "電話番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(175, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "ショップ名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(174, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "ショップID";
            // 
            // ShopDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shopCancelButton);
            this.Controls.Add(this.shopUpdataButton);
            this.Controls.Add(this.shopFax);
            this.Controls.Add(this.shopAddress);
            this.Controls.Add(this.shopPhone);
            this.Controls.Add(this.shopID);
            this.Controls.Add(this.shopName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ShopDetails";
            this.Size = new System.Drawing.Size(1033, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button shopCancelButton;
        public System.Windows.Forms.Button shopUpdataButton;
        public System.Windows.Forms.TextBox shopFax;
        public System.Windows.Forms.TextBox shopAddress;
        public System.Windows.Forms.TextBox shopPhone;
        public System.Windows.Forms.Label shopID;
        public System.Windows.Forms.TextBox shopName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
