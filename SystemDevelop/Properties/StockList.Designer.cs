namespace SystemDevelop.Properties
{
    partial class StockList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stock_dataGridView = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Seach_textBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.Date_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Stock_dataGridView);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(35, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 279);
            this.panel1.TabIndex = 13;
            // 
            // Stock_dataGridView
            // 
            this.Stock_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stock_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.Column1});
            this.Stock_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stock_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Stock_dataGridView.Name = "Stock_dataGridView";
            this.Stock_dataGridView.RowTemplate.Height = 21;
            this.Stock_dataGridView.Size = new System.Drawing.Size(524, 279);
            this.Stock_dataGridView.TabIndex = 1;
            // 
            // a
            // 
            this.a.HeaderText = "商品コード";
            this.a.Name = "a";
            this.a.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "在庫数";
            this.Column1.Name = "Column1";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(524, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 279);
            this.vScrollBar1.TabIndex = 0;
            // 
            // Seach_textBox
            // 
            this.Seach_textBox.Location = new System.Drawing.Point(35, 88);
            this.Seach_textBox.Name = "Seach_textBox";
            this.Seach_textBox.Size = new System.Drawing.Size(159, 19);
            this.Seach_textBox.TabIndex = 12;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.back_button.Location = new System.Drawing.Point(514, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(88, 41);
            this.back_button.TabIndex = 24;
            this.back_button.Text = "もどる";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Home_button.Image = global::SystemDevelop.Properties.Resources.touka_home1;
            this.Home_button.Location = new System.Drawing.Point(420, 12);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(88, 41);
            this.Home_button.TabIndex = 23;
            this.Home_button.Text = "ホーム";
            this.Home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_button.UseVisualStyleBackColor = true;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(110, 26);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(29, 12);
            this.Date_label.TabIndex = 22;
            this.Date_label.Text = "日付";
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Location = new System.Drawing.Point(33, 26);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(57, 12);
            this.UserName_label.TabIndex = 21;
            this.UserName_label.Text = "ユーザー名";
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 461);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Seach_textBox);
            this.Name = "StockList";
            this.Text = "在庫一覧";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stock_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Stock_dataGridView;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox Seach_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label UserName_label;
    }
}