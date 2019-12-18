namespace SystemDevelop.UserControls
{
    partial class StockDetails
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
            this.stockCount = new System.Windows.Forms.TextBox();
            this.stockID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(323, 580);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(170, 60);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // updata
            // 
            this.updata.Location = new System.Drawing.Point(560, 580);
            this.updata.Name = "updata";
            this.updata.Size = new System.Drawing.Size(170, 60);
            this.updata.TabIndex = 2;
            this.updata.Text = "更新";
            this.updata.UseVisualStyleBackColor = true;
            // 
            // stockCount
            // 
            this.stockCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockCount.Location = new System.Drawing.Point(511, 451);
            this.stockCount.Name = "stockCount";
            this.stockCount.Size = new System.Drawing.Size(340, 31);
            this.stockCount.TabIndex = 1;
            // 
            // stockID
            // 
            this.stockID.AutoSize = true;
            this.stockID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stockID.Location = new System.Drawing.Point(635, 111);
            this.stockID.Name = "stockID";
            this.stockID.Size = new System.Drawing.Size(79, 24);
            this.stockID.TabIndex = 36;
            this.stockID.Text = "id_label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(185, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "在庫数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(185, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "商品ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(185, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "在庫ID";
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productID.Location = new System.Drawing.Point(635, 287);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(79, 24);
            this.productID.TabIndex = 37;
            this.productID.Text = "id_label";
            // 
            // StockDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productID);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.updata);
            this.Controls.Add(this.stockCount);
            this.Controls.Add(this.stockID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "StockDetails";
            this.Size = new System.Drawing.Size(1033, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.Button updata;
        public System.Windows.Forms.TextBox stockCount;
        public System.Windows.Forms.Label stockID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label productID;
    }
}
