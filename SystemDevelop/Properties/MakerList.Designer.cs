namespace SystemDevelop.Properties
{
    partial class MakerList
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
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Maker_dataGridView = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.back_button = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.Date_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maker_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(35, 87);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(159, 19);
            this.Search_textBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Maker_dataGridView);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(35, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 279);
            this.panel1.TabIndex = 7;
            // 
            // Maker_dataGridView
            // 
            this.Maker_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Maker_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.Column1,
            this.Column2,
            this.Column3});
            this.Maker_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maker_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Maker_dataGridView.Name = "Maker_dataGridView";
            this.Maker_dataGridView.RowTemplate.Height = 21;
            this.Maker_dataGridView.Size = new System.Drawing.Size(524, 279);
            this.Maker_dataGridView.TabIndex = 1;
            this.Maker_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // a
            // 
            this.a.HeaderText = "メーカーID ";
            this.a.Name = "a";
            this.a.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "メーカー名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "電話番号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FAX番号";
            this.Column3.Name = "Column3";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(524, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 279);
            this.vScrollBar1.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.back_button.Location = new System.Drawing.Point(514, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(88, 41);
            this.back_button.TabIndex = 41;
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
            this.Home_button.TabIndex = 40;
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
            this.Date_label.TabIndex = 39;
            this.Date_label.Text = "日付";
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Location = new System.Drawing.Point(33, 26);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(57, 12);
            this.UserName_label.TabIndex = 38;
            this.UserName_label.Text = "ユーザー名";
            // 
            // MakerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 461);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Search_textBox);
            this.Name = "MakerList";
            this.Text = "メーカー一覧";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Maker_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridView Maker_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label UserName_label;
    }
}