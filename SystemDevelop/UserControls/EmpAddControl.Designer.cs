namespace SystemDevelop.UserControls
{
    partial class EmpAddControl
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
            this.empKanaTextBox = new System.Windows.Forms.TextBox();
            this.empAddButton = new System.Windows.Forms.Button();
            this.pigeonLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.shopLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.empId = new System.Windows.Forms.Label();
            this.empCancelButton = new System.Windows.Forms.Button();
            this.affiliationAddComboBox = new System.Windows.Forms.ComboBox();
            this.affiliationId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empPhoneTextBox = new System.Windows.Forms.TextBox();
            this.psswordAddTextBox = new System.Windows.Forms.TextBox();
            this.pigeonAddTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // empKanaTextBox
            // 
            this.empKanaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empKanaTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empKanaTextBox.Location = new System.Drawing.Point(371, 216);
            this.empKanaTextBox.Name = "empKanaTextBox";
            this.empKanaTextBox.Size = new System.Drawing.Size(398, 39);
            this.empKanaTextBox.TabIndex = 17;
            // 
            // empAddButton
            // 
            this.empAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.empAddButton.AutoSize = true;
            this.empAddButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empAddButton.Location = new System.Drawing.Point(719, 649);
            this.empAddButton.Name = "empAddButton";
            this.empAddButton.Size = new System.Drawing.Size(104, 43);
            this.empAddButton.TabIndex = 21;
            this.empAddButton.Text = "登録";
            this.empAddButton.UseVisualStyleBackColor = true;
            this.empAddButton.Click += new System.EventHandler(this.empAddButton_Click);
            // 
            // pigeonLabel
            // 
            this.pigeonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonLabel.AutoSize = true;
            this.pigeonLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonLabel.Location = new System.Drawing.Point(146, 284);
            this.pigeonLabel.Name = "pigeonLabel";
            this.pigeonLabel.Size = new System.Drawing.Size(112, 33);
            this.pigeonLabel.TabIndex = 22;
            this.pigeonLabel.Text = "所属ID";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.amountLabel.Location = new System.Drawing.Point(146, 219);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(132, 33);
            this.amountLabel.TabIndex = 20;
            this.amountLabel.Text = "社員カナ";
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productLabel.Location = new System.Drawing.Point(146, 154);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(114, 33);
            this.productLabel.TabIndex = 18;
            this.productLabel.Text = "社員名";
            // 
            // shopLabel
            // 
            this.shopLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopLabel.Location = new System.Drawing.Point(146, 93);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(112, 33);
            this.shopLabel.TabIndex = 13;
            this.shopLabel.Text = "社員ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(146, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 31;
            this.label2.Text = "所属名";
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empNameTextBox.Location = new System.Drawing.Point(371, 151);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.Size = new System.Drawing.Size(398, 39);
            this.empNameTextBox.TabIndex = 34;
            // 
            // empId
            // 
            this.empId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.empId.AutoSize = true;
            this.empId.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empId.Location = new System.Drawing.Point(365, 93);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(117, 33);
            this.empId.TabIndex = 35;
            this.empId.Text = "id_label";
            // 
            // empCancelButton
            // 
            this.empCancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.empCancelButton.AutoSize = true;
            this.empCancelButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empCancelButton.Location = new System.Drawing.Point(541, 649);
            this.empCancelButton.Name = "empCancelButton";
            this.empCancelButton.Size = new System.Drawing.Size(153, 43);
            this.empCancelButton.TabIndex = 37;
            this.empCancelButton.Text = "キャンセル";
            this.empCancelButton.UseVisualStyleBackColor = true;
            // 
            // affiliationAddComboBox
            // 
            this.affiliationAddComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.affiliationAddComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affiliationAddComboBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.affiliationAddComboBox.FormattingEnabled = true;
            this.affiliationAddComboBox.Location = new System.Drawing.Point(371, 347);
            this.affiliationAddComboBox.Name = "affiliationAddComboBox";
            this.affiliationAddComboBox.Size = new System.Drawing.Size(398, 41);
            this.affiliationAddComboBox.TabIndex = 30;
            this.affiliationAddComboBox.TextChanged += new System.EventHandler(this.affiliationAddComboBox_TextChanged);
            // 
            // affiliationId
            // 
            this.affiliationId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.affiliationId.AutoSize = true;
            this.affiliationId.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.affiliationId.Location = new System.Drawing.Point(365, 284);
            this.affiliationId.Name = "affiliationId";
            this.affiliationId.Size = new System.Drawing.Size(348, 33);
            this.affiliationId.TabIndex = 36;
            this.affiliationId.Text = "所属名を選択してください";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(146, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "パスワード";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(146, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 33);
            this.label4.TabIndex = 28;
            this.label4.Text = "電話番号";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(146, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "ハト名";
            // 
            // empPhoneTextBox
            // 
            this.empPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.empPhoneTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empPhoneTextBox.Location = new System.Drawing.Point(371, 477);
            this.empPhoneTextBox.Name = "empPhoneTextBox";
            this.empPhoneTextBox.Size = new System.Drawing.Size(398, 39);
            this.empPhoneTextBox.TabIndex = 26;
            // 
            // psswordAddTextBox
            // 
            this.psswordAddTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.psswordAddTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.psswordAddTextBox.Location = new System.Drawing.Point(371, 417);
            this.psswordAddTextBox.Name = "psswordAddTextBox";
            this.psswordAddTextBox.Size = new System.Drawing.Size(398, 39);
            this.psswordAddTextBox.TabIndex = 33;
            // 
            // pigeonAddTextBox
            // 
            this.pigeonAddTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonAddTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonAddTextBox.Location = new System.Drawing.Point(371, 539);
            this.pigeonAddTextBox.Name = "pigeonAddTextBox";
            this.pigeonAddTextBox.Size = new System.Drawing.Size(398, 39);
            this.pigeonAddTextBox.TabIndex = 32;
            // 
            // EmpAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.empCancelButton);
            this.Controls.Add(this.affiliationId);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.empNameTextBox);
            this.Controls.Add(this.psswordAddTextBox);
            this.Controls.Add(this.pigeonAddTextBox);
            this.Controls.Add(this.affiliationAddComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empPhoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empKanaTextBox);
            this.Controls.Add(this.empAddButton);
            this.Controls.Add(this.pigeonLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.shopLabel);
            this.Name = "EmpAddControl";
            this.Size = new System.Drawing.Size(1033, 789);
            this.Load += new System.EventHandler(this.EmpAddControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox empKanaTextBox;
        private System.Windows.Forms.Label pigeonLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.Label empId;
        public System.Windows.Forms.Button empAddButton;
        public System.Windows.Forms.Button empCancelButton;
        private System.Windows.Forms.ComboBox affiliationAddComboBox;
        private System.Windows.Forms.Label affiliationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empPhoneTextBox;
        private System.Windows.Forms.TextBox psswordAddTextBox;
        private System.Windows.Forms.TextBox pigeonAddTextBox;
    }
}
