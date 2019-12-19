namespace SystemDevelop.UserControls
{
    partial class OrderDetails
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
            this.prderCancelButton = new System.Windows.Forms.Button();
            this.orderUpdataButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paolDate = new System.Windows.Forms.Label();
            this.paolName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prderCancelButton
            // 
            this.prderCancelButton.Location = new System.Drawing.Point(278, 584);
            this.prderCancelButton.Name = "prderCancelButton";
            this.prderCancelButton.Size = new System.Drawing.Size(170, 60);
            this.prderCancelButton.TabIndex = 2;
            this.prderCancelButton.Text = "キャンセル";
            this.prderCancelButton.UseVisualStyleBackColor = true;
            // 
            // orderUpdataButton
            // 
            this.orderUpdataButton.Location = new System.Drawing.Point(515, 584);
            this.orderUpdataButton.Name = "orderUpdataButton";
            this.orderUpdataButton.Size = new System.Drawing.Size(170, 60);
            this.orderUpdataButton.TabIndex = 1;
            this.orderUpdataButton.Text = "更新";
            this.orderUpdataButton.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.id.Location = new System.Drawing.Point(637, 122);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(79, 24);
            this.id.TabIndex = 35;
            this.id.Text = "id_label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(187, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "発注日付\t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(187, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "発注担当者\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(187, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "発注ID";
            // 
            // paolDate
            // 
            this.paolDate.AutoSize = true;
            this.paolDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paolDate.Location = new System.Drawing.Point(637, 297);
            this.paolDate.Name = "paolDate";
            this.paolDate.Size = new System.Drawing.Size(105, 24);
            this.paolDate.TabIndex = 44;
            this.paolDate.Text = "date_label";
            // 
            // paolName
            // 
            this.paolName.AutoSize = true;
            this.paolName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paolName.Location = new System.Drawing.Point(637, 468);
            this.paolName.Name = "paolName";
            this.paolName.Size = new System.Drawing.Size(115, 24);
            this.paolName.TabIndex = 45;
            this.paolName.Text = "name_label";
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paolName);
            this.Controls.Add(this.paolDate);
            this.Controls.Add(this.prderCancelButton);
            this.Controls.Add(this.orderUpdataButton);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "OrderDetails";
            this.Size = new System.Drawing.Size(1033, 706);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label paolName;
        public System.Windows.Forms.Button prderCancelButton;
        public System.Windows.Forms.Button orderUpdataButton;
        public System.Windows.Forms.Label id;
        public System.Windows.Forms.Label paolDate;
    }
}
