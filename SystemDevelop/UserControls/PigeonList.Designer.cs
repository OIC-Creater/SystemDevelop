namespace SystemDevelop.UserControls
{
    partial class PigeonList
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
            this.pigeonGridView = new System.Windows.Forms.DataGridView();
            this.updata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pigeonGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pigeonGridView
            // 
            this.pigeonGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pigeonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pigeonGridView.Location = new System.Drawing.Point(0, 0);
            this.pigeonGridView.MultiSelect = false;
            this.pigeonGridView.Name = "pigeonGridView";
            this.pigeonGridView.RowTemplate.Height = 21;
            this.pigeonGridView.Size = new System.Drawing.Size(1033, 709);
            this.pigeonGridView.TabIndex = 0;
            this.pigeonGridView.TabStop = false;
            // 
            // updata
            // 
            this.updata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updata.Location = new System.Drawing.Point(873, 709);
            this.updata.Name = "updata";
            this.updata.Size = new System.Drawing.Size(160, 80);
            this.updata.TabIndex = 1;
            this.updata.Text = "更新";
            this.updata.UseVisualStyleBackColor = true;
            // 
            // PigeonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updata);
            this.Controls.Add(this.pigeonGridView);
            this.Name = "PigeonList";
            this.Size = new System.Drawing.Size(1033, 789);
            this.Load += new System.EventHandler(this.Pigeon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pigeonGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button updata;
        public System.Windows.Forms.DataGridView pigeonGridView;
    }
}
