namespace SystemDevelop.UserControls
{
    partial class ProductDetails
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
            this.empCancelButton = new System.Windows.Forms.Button();
            this.empUpdataButton = new System.Windows.Forms.Button();
            this.empHiring = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.empPhone = new System.Windows.Forms.TextBox();
            this.empPassword = new System.Windows.Forms.TextBox();
            this.empAffiliation = new System.Windows.Forms.TextBox();
            this.empID = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // empCancelButton
            // 
            this.empCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empCancelButton.Location = new System.Drawing.Point(291, 554);
            this.empCancelButton.Name = "empCancelButton";
            this.empCancelButton.Size = new System.Drawing.Size(170, 60);
            this.empCancelButton.TabIndex = 30;
            this.empCancelButton.Text = "キャンセル";
            this.empCancelButton.UseVisualStyleBackColor = true;
            // 
            // empUpdataButton
            // 
            this.empUpdataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empUpdataButton.Location = new System.Drawing.Point(528, 554);
            this.empUpdataButton.Name = "empUpdataButton";
            this.empUpdataButton.Size = new System.Drawing.Size(170, 60);
            this.empUpdataButton.TabIndex = 29;
            this.empUpdataButton.Text = "更新";
            this.empUpdataButton.UseVisualStyleBackColor = true;
            // 
            // empHiring
            // 
            this.empHiring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empHiring.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empHiring.FormattingEnabled = true;
            this.empHiring.Items.AddRange(new object[] {
            "雇用",
            "離職済"});
            this.empHiring.Location = new System.Drawing.Point(477, 461);
            this.empHiring.Name = "empHiring";
            this.empHiring.Size = new System.Drawing.Size(340, 41);
            this.empHiring.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(115, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 33);
            this.label7.TabIndex = 38;
            this.label7.Text = "雇用中\t";
            // 
            // empPhone
            // 
            this.empPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empPhone.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empPhone.Location = new System.Drawing.Point(477, 369);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(340, 39);
            this.empPhone.TabIndex = 26;
            // 
            // empPassword
            // 
            this.empPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empPassword.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empPassword.Location = new System.Drawing.Point(479, 280);
            this.empPassword.Name = "empPassword";
            this.empPassword.Size = new System.Drawing.Size(340, 39);
            this.empPassword.TabIndex = 25;
            // 
            // empAffiliation
            // 
            this.empAffiliation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empAffiliation.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empAffiliation.Location = new System.Drawing.Point(479, 196);
            this.empAffiliation.Name = "empAffiliation";
            this.empAffiliation.Size = new System.Drawing.Size(340, 39);
            this.empAffiliation.TabIndex = 24;
            // 
            // empID
            // 
            this.empID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empID.AutoSize = true;
            this.empID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empID.Location = new System.Drawing.Point(473, 41);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(109, 33);
            this.empID.TabIndex = 36;
            this.empID.Text = "id_label";
            // 
            // empName
            // 
            this.empName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empName.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empName.Location = new System.Drawing.Point(479, 105);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(340, 39);
            this.empName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(112, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 33);
            this.label6.TabIndex = 35;
            this.label6.Text = "メーカID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(114, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "売価\t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(115, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 33);
            this.label4.TabIndex = 33;
            this.label4.Text = "原価";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(114, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 33);
            this.label3.TabIndex = 32;
            this.label3.Text = "商品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(114, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 31;
            this.label2.Text = "商品ID";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.empCancelButton);
            this.Controls.Add(this.empUpdataButton);
            this.Controls.Add(this.empHiring);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.empPhone);
            this.Controls.Add(this.empPassword);
            this.Controls.Add(this.empAffiliation);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ProductDetails";
            this.Size = new System.Drawing.Size(1045, 629);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button empCancelButton;
        public System.Windows.Forms.Button empUpdataButton;
        public System.Windows.Forms.ComboBox empHiring;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox empPhone;
        public System.Windows.Forms.TextBox empPassword;
        public System.Windows.Forms.TextBox empAffiliation;
        public System.Windows.Forms.Label empID;
        public System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
