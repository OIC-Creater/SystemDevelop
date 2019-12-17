namespace SystemDevelop.UserControls
{
    partial class OrderListDetails
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
            this.cancel = new System.Windows.Forms.Button();
            this.updata = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.orderDetailsID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderID = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(251, 565);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(170, 60);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // updata
            // 
            this.updata.Location = new System.Drawing.Point(488, 565);
            this.updata.Name = "updata";
            this.updata.Size = new System.Drawing.Size(170, 60);
            this.updata.TabIndex = 3;
            this.updata.Text = "更新";
            this.updata.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password.Location = new System.Drawing.Point(435, 460);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(340, 31);
            this.password.TabIndex = 2;
            // 
            // orderDetailsID
            // 
            this.orderDetailsID.AutoSize = true;
            this.orderDetailsID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderDetailsID.Location = new System.Drawing.Point(559, 69);
            this.orderDetailsID.Name = "orderDetailsID";
            this.orderDetailsID.Size = new System.Drawing.Size(79, 24);
            this.orderDetailsID.TabIndex = 36;
            this.orderDetailsID.Text = "id_label";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(108, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "個数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(109, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "商品ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(109, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "受注ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(109, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "受注明細ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(435, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(109, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "商品名";
            // 
            // orderID
            // 
            this.orderID.AutoSize = true;
            this.orderID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.orderID.Location = new System.Drawing.Point(559, 166);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(79, 24);
            this.orderID.TabIndex = 39;
            this.orderID.Text = "id_label";
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productID.Location = new System.Drawing.Point(559, 251);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(79, 24);
            this.productID.TabIndex = 40;
            this.productID.Text = "id_label";
            // 
            // OrderListDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productID);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.updata);
            this.Controls.Add(this.password);
            this.Controls.Add(this.orderDetailsID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "OrderListDetails";
            this.Size = new System.Drawing.Size(1033, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.Button updata;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.Label orderDetailsID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label orderID;
        public System.Windows.Forms.Label productID;
    }
}
