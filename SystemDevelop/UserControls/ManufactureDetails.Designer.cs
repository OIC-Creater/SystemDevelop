namespace SystemDevelop.UserControls
{
    partial class ManufactureDetails
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
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.updata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.address.Location = new System.Drawing.Point(458, 444);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(340, 31);
            this.address.TabIndex = 3;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.phone.Location = new System.Drawing.Point(458, 330);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(340, 31);
            this.phone.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.id.Location = new System.Drawing.Point(582, 91);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(79, 24);
            this.id.TabIndex = 33;
            this.id.Text = "id_label";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.name.Location = new System.Drawing.Point(458, 213);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(340, 31);
            this.name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(131, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "住所\t\t\t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(132, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "電話番号\t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(131, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "メーカ名\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(132, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "メーカID\t";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(296, 550);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(170, 60);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // updata
            // 
            this.updata.Location = new System.Drawing.Point(533, 550);
            this.updata.Name = "updata";
            this.updata.Size = new System.Drawing.Size(170, 60);
            this.updata.TabIndex = 4;
            this.updata.Text = "更新";
            this.updata.UseVisualStyleBackColor = true;
            // 
            // ManufactureDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.updata);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManufactureDetails";
            this.Size = new System.Drawing.Size(1033, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox address;
        public System.Windows.Forms.TextBox phone;
        public System.Windows.Forms.Label id;
        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.Button updata;
    }
}
