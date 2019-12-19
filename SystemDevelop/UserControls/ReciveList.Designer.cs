namespace SystemDevelop.UserControls
{
    partial class ReciveList
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
            this.reciveGridView = new System.Windows.Forms.DataGridView();
            this.reciveDetailButton = new System.Windows.Forms.Button();
            this.reciveListAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reciveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reciveGridView
            // 
            this.reciveGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reciveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reciveGridView.Location = new System.Drawing.Point(0, 0);
            this.reciveGridView.MultiSelect = false;
            this.reciveGridView.Name = "reciveGridView";
            this.reciveGridView.RowTemplate.Height = 21;
            this.reciveGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reciveGridView.Size = new System.Drawing.Size(1033, 709);
            this.reciveGridView.TabIndex = 0;
            this.reciveGridView.TabStop = false;
            // 
            // reciveDetailButton
            // 
            this.reciveDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveDetailButton.Location = new System.Drawing.Point(873, 709);
            this.reciveDetailButton.Name = "reciveDetailButton";
            this.reciveDetailButton.Size = new System.Drawing.Size(160, 80);
            this.reciveDetailButton.TabIndex = 1;
            this.reciveDetailButton.Text = "詳細";
            this.reciveDetailButton.UseVisualStyleBackColor = true;
            // 
            // reciveListAddButton
            // 
            this.reciveListAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveListAddButton.Location = new System.Drawing.Point(707, 709);
            this.reciveListAddButton.Name = "reciveListAddButton";
            this.reciveListAddButton.Size = new System.Drawing.Size(160, 80);
            this.reciveListAddButton.TabIndex = 3;
            this.reciveListAddButton.Text = "受注登録";
            this.reciveListAddButton.UseVisualStyleBackColor = true;
            // 
            // ReciveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reciveListAddButton);
            this.Controls.Add(this.reciveDetailButton);
            this.Controls.Add(this.reciveGridView);
            this.Name = "ReciveList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.reciveGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView reciveGridView;
        public System.Windows.Forms.Button reciveDetailButton;
        public System.Windows.Forms.Button reciveListAddButton;
    }
}
