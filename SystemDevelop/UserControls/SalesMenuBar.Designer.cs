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
            this.reciveAddButton = new System.Windows.Forms.Button();
            this.reciveListButton = new System.Windows.Forms.Button();
            this.pigeonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reciveAddButton
            // 
            this.reciveAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveAddButton.BackColor = System.Drawing.SystemColors.Control;
            this.reciveAddButton.FlatAppearance.BorderSize = 0;
            this.reciveAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciveAddButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reciveAddButton.Location = new System.Drawing.Point(0, 104);
            this.reciveAddButton.Name = "reciveAddButton";
            this.reciveAddButton.Size = new System.Drawing.Size(216, 104);
            this.reciveAddButton.TabIndex = 2;
            this.reciveAddButton.Text = "受注登録";
            this.reciveAddButton.UseVisualStyleBackColor = false;
            this.reciveAddButton.Click += new System.EventHandler(this.recive_Click);
            // 
            // reciveListButton
            // 
            this.reciveListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveListButton.BackColor = System.Drawing.SystemColors.Control;
            this.reciveListButton.FlatAppearance.BorderSize = 0;
            this.reciveListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciveListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reciveListButton.Location = new System.Drawing.Point(0, 0);
            this.reciveListButton.Name = "reciveListButton";
            this.reciveListButton.Size = new System.Drawing.Size(216, 104);
            this.reciveListButton.TabIndex = 1;
            this.reciveListButton.Text = "受注一覧";
            this.reciveListButton.UseVisualStyleBackColor = false;
            this.reciveListButton.Click += new System.EventHandler(this.reciveDetail_Click);
            // 
            // pigeonButton
            // 
            this.pigeonButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonButton.BackColor = System.Drawing.SystemColors.Control;
            this.pigeonButton.FlatAppearance.BorderSize = 0;
            this.pigeonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pigeonButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonButton.Location = new System.Drawing.Point(0, 208);
            this.pigeonButton.Name = "pigeonButton";
            this.pigeonButton.Size = new System.Drawing.Size(216, 104);
            this.pigeonButton.TabIndex = 3;
            this.pigeonButton.Text = "ハト管理";
            this.pigeonButton.UseVisualStyleBackColor = false;
            this.pigeonButton.Click += new System.EventHandler(this.pigeon_Click);
            // 
            // SalesMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pigeonButton);
            this.Controls.Add(this.reciveListButton);
            this.Controls.Add(this.reciveAddButton);
            this.Name = "SalesMenuBar";
            this.Size = new System.Drawing.Size(216, 689);
            this.Load += new System.EventHandler(this.MenuBar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button reciveListButton;
        public System.Windows.Forms.Button reciveAddButton;
        public System.Windows.Forms.Button pigeonButton;
    }
}
