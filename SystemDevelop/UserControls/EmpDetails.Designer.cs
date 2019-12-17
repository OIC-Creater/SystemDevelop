namespace SystemDevelop.UserControls
{
    partial class EmpDetails
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
            this.pigeonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empHiring = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.updata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empPhone
            // 
            this.empPhone.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empPhone.Location = new System.Drawing.Point(464, 348);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(340, 31);
            this.empPhone.TabIndex = 4;
            // 
            // empPassword
            // 
            this.empPassword.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empPassword.Location = new System.Drawing.Point(465, 277);
            this.empPassword.Name = "empPassword";
            this.empPassword.Size = new System.Drawing.Size(340, 31);
            this.empPassword.TabIndex = 3;
            // 
            // empAffiliation
            // 
            this.empAffiliation.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empAffiliation.Location = new System.Drawing.Point(464, 207);
            this.empAffiliation.Name = "empAffiliation";
            this.empAffiliation.Size = new System.Drawing.Size(340, 31);
            this.empAffiliation.TabIndex = 2;
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empID.Location = new System.Drawing.Point(588, 71);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(79, 24);
            this.empID.TabIndex = 18;
            this.empID.Text = "id_label";
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empName.Location = new System.Drawing.Point(465, 138);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(340, 31);
            this.empName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(138, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "電話番号\t\t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(138, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "パスワード\t\t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(138, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "所属名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(138, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "社員名\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(138, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "社員ID";
            // 
            // pigeonName
            // 
            this.pigeonName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonName.Location = new System.Drawing.Point(463, 422);
            this.pigeonName.Name = "pigeonName";
            this.pigeonName.Size = new System.Drawing.Size(340, 31);
            this.pigeonName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(139, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "ハト名\t";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(139, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "雇用中\t";
            // 
            // empHiring
            // 
            this.empHiring.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.empHiring.FormattingEnabled = true;
            this.empHiring.Items.AddRange(new object[] {
            "雇用",
            "離職済"});
            this.empHiring.Location = new System.Drawing.Point(463, 491);
            this.empHiring.Name = "empHiring";
            this.empHiring.Size = new System.Drawing.Size(340, 32);
            this.empHiring.TabIndex = 6;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(278, 584);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(170, 60);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // updata
            // 
            this.updata.Location = new System.Drawing.Point(515, 584);
            this.updata.Name = "updata";
            this.updata.Size = new System.Drawing.Size(170, 60);
            this.updata.TabIndex = 7;
            this.updata.Text = "更新";
            this.updata.UseVisualStyleBackColor = true;
            // 
            // EmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.updata);
            this.Controls.Add(this.empHiring);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pigeonName);
            this.Controls.Add(this.label1);
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
            this.Name = "EmpDetails";
            this.Size = new System.Drawing.Size(1033, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox empPhone;
        public System.Windows.Forms.TextBox empPassword;
        public System.Windows.Forms.TextBox empAffiliation;
        public System.Windows.Forms.Label empID;
        public System.Windows.Forms.TextBox empName;
        public System.Windows.Forms.TextBox pigeonName;
        public System.Windows.Forms.ComboBox empHiring;
        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.Button updata;
    }
}
