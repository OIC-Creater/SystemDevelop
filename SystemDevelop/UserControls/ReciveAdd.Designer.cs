namespace SystemDevelop.UserControls
{
    partial class ReciveAdd
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
            this.shopLabel = new System.Windows.Forms.Label();
            this.honorificLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.pigeonLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.shopComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.pigeonComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.piecesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shopLabel
            // 
            this.shopLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopLabel.Location = new System.Drawing.Point(160, 94);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(104, 33);
            this.shopLabel.TabIndex = 0;
            this.shopLabel.Text = "ショップ";
            // 
            // honorificLabel
            // 
            this.honorificLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.honorificLabel.AutoSize = true;
            this.honorificLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.honorificLabel.Location = new System.Drawing.Point(789, 97);
            this.honorificLabel.Name = "honorificLabel";
            this.honorificLabel.Size = new System.Drawing.Size(48, 33);
            this.honorificLabel.TabIndex = 1;
            this.honorificLabel.Text = "様";
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productLabel.Location = new System.Drawing.Point(160, 249);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(81, 33);
            this.productLabel.TabIndex = 3;
            this.productLabel.Text = "商品";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountLabel.Location = new System.Drawing.Point(160, 384);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(81, 33);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "数量";
            // 
            // pigeonLabel
            // 
            this.pigeonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonLabel.AutoSize = true;
            this.pigeonLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonLabel.Location = new System.Drawing.Point(160, 514);
            this.pigeonLabel.Name = "pigeonLabel";
            this.pigeonLabel.Size = new System.Drawing.Size(133, 33);
            this.pigeonLabel.TabIndex = 6;
            this.pigeonLabel.Text = "担当ハト";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addButton.Location = new System.Drawing.Point(733, 650);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 43);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "登録";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // shopComboBox
            // 
            this.shopComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shopComboBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopComboBox.FormattingEnabled = true;
            this.shopComboBox.ItemHeight = 33;
            this.shopComboBox.Location = new System.Drawing.Point(385, 91);
            this.shopComboBox.Name = "shopComboBox";
            this.shopComboBox.Size = new System.Drawing.Size(398, 41);
            this.shopComboBox.TabIndex = 1;
            // 
            // productComboBox
            // 
            this.productComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productComboBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(385, 241);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(398, 41);
            this.productComboBox.TabIndex = 2;
            // 
            // pigeonComboBox
            // 
            this.pigeonComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonComboBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonComboBox.FormattingEnabled = true;
            this.pigeonComboBox.Location = new System.Drawing.Point(385, 511);
            this.pigeonComboBox.Name = "pigeonComboBox";
            this.pigeonComboBox.Size = new System.Drawing.Size(398, 41);
            this.pigeonComboBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountTextBox.Location = new System.Drawing.Point(385, 381);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(398, 39);
            this.amountTextBox.TabIndex = 3;
            // 
            // piecesLabel
            // 
            this.piecesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.piecesLabel.AutoSize = true;
            this.piecesLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.piecesLabel.Location = new System.Drawing.Point(789, 384);
            this.piecesLabel.Name = "piecesLabel";
            this.piecesLabel.Size = new System.Drawing.Size(48, 33);
            this.piecesLabel.TabIndex = 12;
            this.piecesLabel.Text = "個";
            // 
            // Recive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.piecesLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.pigeonComboBox);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.shopComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pigeonLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.honorificLabel);
            this.Controls.Add(this.shopLabel);
            this.Name = "Recive";
            this.Size = new System.Drawing.Size(1033, 789);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label honorificLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label pigeonLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox shopComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox pigeonComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label piecesLabel;
    }
}
