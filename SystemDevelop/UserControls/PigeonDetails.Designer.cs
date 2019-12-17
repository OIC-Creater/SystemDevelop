namespace SystemDevelop.UserControls
{
    partial class PigeonDetails
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
            this.pigeonID = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.updata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pigeonID
            // 
            this.pigeonID.AutoSize = true;
            this.pigeonID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonID.Location = new System.Drawing.Point(568, 116);
            this.pigeonID.Name = "pigeonID";
            this.pigeonID.Size = new System.Drawing.Size(79, 24);
            this.pigeonID.TabIndex = 26;
            this.pigeonID.Text = "id_label";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.name.Location = new System.Drawing.Point(445, 285);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(340, 31);
            this.name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(118, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "ステータス名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(118, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "ハト名\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(118, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "ハトID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-15, -15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 27;
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(445, 448);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(340, 32);
            this.status.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(312, 581);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(170, 60);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // updata
            // 
            this.updata.Location = new System.Drawing.Point(549, 581);
            this.updata.Name = "updata";
            this.updata.Size = new System.Drawing.Size(170, 60);
            this.updata.TabIndex = 3;
            this.updata.Text = "更新";
            this.updata.UseVisualStyleBackColor = true;
            // 
            // PigeonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.updata);
            this.Controls.Add(this.status);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pigeonID);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "PigeonDetails";
            this.Size = new System.Drawing.Size(1033, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label pigeonID;
        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox status;
        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.Button updata;
    }
}
