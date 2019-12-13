namespace SystemDevelop.UserControls
{
    partial class SalesMenuBar
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
            this.recive = new System.Windows.Forms.Button();
            this.reciveDetail = new System.Windows.Forms.Button();
            this.pigeon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recive
            // 
            this.recive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recive.BackColor = System.Drawing.SystemColors.Control;
            this.recive.FlatAppearance.BorderSize = 0;
            this.recive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recive.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.recive.Location = new System.Drawing.Point(0, 104);
            this.recive.Name = "recive";
            this.recive.Size = new System.Drawing.Size(216, 104);
            this.recive.TabIndex = 2;
            this.recive.Text = "受注登録";
            this.recive.UseVisualStyleBackColor = false;
            this.recive.Click += new System.EventHandler(this.recive_Click);
            // 
            // reciveDetail
            // 
            this.reciveDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveDetail.BackColor = System.Drawing.SystemColors.Control;
            this.reciveDetail.FlatAppearance.BorderSize = 0;
            this.reciveDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciveDetail.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reciveDetail.Location = new System.Drawing.Point(0, 0);
            this.reciveDetail.Name = "reciveDetail";
            this.reciveDetail.Size = new System.Drawing.Size(216, 104);
            this.reciveDetail.TabIndex = 1;
            this.reciveDetail.Text = "受注一覧";
            this.reciveDetail.UseVisualStyleBackColor = false;
            this.reciveDetail.Click += new System.EventHandler(this.reciveDetail_Click);
            // 
            // pigeon
            // 
            this.pigeon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeon.BackColor = System.Drawing.SystemColors.Control;
            this.pigeon.FlatAppearance.BorderSize = 0;
            this.pigeon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pigeon.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeon.Location = new System.Drawing.Point(0, 208);
            this.pigeon.Name = "pigeon";
            this.pigeon.Size = new System.Drawing.Size(216, 104);
            this.pigeon.TabIndex = 3;
            this.pigeon.Text = "ハト管理";
            this.pigeon.UseVisualStyleBackColor = false;
            this.pigeon.Click += new System.EventHandler(this.pigeon_Click);
            // 
            // SalesMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pigeon);
            this.Controls.Add(this.reciveDetail);
            this.Controls.Add(this.recive);
            this.Name = "SalesMenuBar";
            this.Size = new System.Drawing.Size(216, 689);
            this.Load += new System.EventHandler(this.MenuBar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button reciveDetail;
        public System.Windows.Forms.Button recive;
        public System.Windows.Forms.Button pigeon;
    }
}
