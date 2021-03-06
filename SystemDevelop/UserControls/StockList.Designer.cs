﻿namespace SystemDevelop.UserControls
{
    partial class StockList
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
            this.stockGridView = new System.Windows.Forms.DataGridView();
            this.stockDetailButton = new System.Windows.Forms.Button();
            this.stockListAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockGridView
            // 
            this.stockGridView.AllowUserToAddRows = false;
            this.stockGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.stockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGridView.Location = new System.Drawing.Point(0, 0);
            this.stockGridView.MultiSelect = false;
            this.stockGridView.Name = "stockGridView";
            this.stockGridView.ReadOnly = true;
            this.stockGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.stockGridView.RowTemplate.Height = 21;
            this.stockGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockGridView.Size = new System.Drawing.Size(1033, 709);
            this.stockGridView.TabIndex = 0;
            this.stockGridView.TabStop = false;
            this.stockGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stockDetailButton
            // 
            this.stockDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockDetailButton.Location = new System.Drawing.Point(873, 709);
            this.stockDetailButton.Name = "stockDetailButton";
            this.stockDetailButton.Size = new System.Drawing.Size(160, 80);
            this.stockDetailButton.TabIndex = 1;
            this.stockDetailButton.Text = "詳細";
            this.stockDetailButton.UseVisualStyleBackColor = true;
            // 
            // stockListAddButton
            // 
            this.stockListAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stockListAddButton.Location = new System.Drawing.Point(707, 709);
            this.stockListAddButton.Name = "stockListAddButton";
            this.stockListAddButton.Size = new System.Drawing.Size(160, 80);
            this.stockListAddButton.TabIndex = 2;
            this.stockListAddButton.Text = "在庫登録";
            this.stockListAddButton.UseVisualStyleBackColor = true;
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stockListAddButton);
            this.Controls.Add(this.stockDetailButton);
            this.Controls.Add(this.stockGridView);
            this.Name = "StockList";
            this.Size = new System.Drawing.Size(1033, 789);
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button stockDetailButton;
        public System.Windows.Forms.Button stockListAddButton;
        public System.Windows.Forms.DataGridView stockGridView;
    }
}
