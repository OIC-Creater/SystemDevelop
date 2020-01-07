namespace SystemDevelop.UserControls
{
    partial class StockAddContorol
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
            this.empId = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.stockAddButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.stockID = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.Label();
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
            // empId
            // 
            this.empId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.empId.AutoSize = true;
            this.empId.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empId.Location = new System.Drawing.Point(397, 117);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(0, 33);
            this.empId.TabIndex = 53;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stockTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockTextBox.Location = new System.Drawing.Point(403, 520);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(398, 39);
            this.stockTextBox.TabIndex = 39;
            // 
            // stockAddButton
            // 
            this.stockAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stockAddButton.AutoSize = true;
            this.stockAddButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockAddButton.Location = new System.Drawing.Point(751, 651);
            this.stockAddButton.Name = "stockAddButton";
            this.stockAddButton.Size = new System.Drawing.Size(104, 43);
            this.stockAddButton.TabIndex = 42;
            this.stockAddButton.Text = "登録";
            this.stockAddButton.UseVisualStyleBackColor = true;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountLabel.Location = new System.Drawing.Point(178, 523);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(114, 33);
            this.amountLabel.TabIndex = 41;
            this.amountLabel.Text = "在庫数";
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productLabel.Location = new System.Drawing.Point(178, 311);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(112, 33);
            this.productLabel.TabIndex = 40;
            this.productLabel.Text = "商品ID";
            // 
            // shopLabel
            // 
            this.shopLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopLabel.Location = new System.Drawing.Point(178, 117);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(112, 33);
            this.shopLabel.TabIndex = 38;
            this.shopLabel.Text = "在庫ID";
            // 
            // stockID
            // 
            this.stockID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stockID.AutoSize = true;
            this.stockID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockID.Location = new System.Drawing.Point(512, 117);
            this.stockID.Name = "stockID";
            this.stockID.Size = new System.Drawing.Size(117, 33);
            this.stockID.TabIndex = 56;
            this.stockID.Text = "id_label";
            // 
            // productID
            // 
            this.productID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productID.AutoSize = true;
            this.productID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productID.Location = new System.Drawing.Point(512, 311);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(117, 33);
            this.productID.TabIndex = 57;
            this.productID.Text = "id_label";
            // 
            // StockAddContorol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productID);
            this.Controls.Add(this.stockID);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.stockAddButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.shopLabel);
            this.Name = "StockAddContorol";
            this.Size = new System.Drawing.Size(1033, 789);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.TextBox stockTextBox;
        public System.Windows.Forms.Button stockAddButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label stockID;
        private System.Windows.Forms.Label productID;
    }
}
