namespace SystemDevelop.Properties
{
    partial class EnployeesList
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
            this.Enployees_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Date_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Home_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Enployees_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Enployees_dataGridView);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(32, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 279);
            this.panel1.TabIndex = 19;
            // 
            // Enployees_dataGridView
            // 
            this.Enployees_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Enployees_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Enployees_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enployees_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Enployees_dataGridView.Name = "Enployees_dataGridView";
            this.Enployees_dataGridView.RowTemplate.Height = 21;
            this.Enployees_dataGridView.Size = new System.Drawing.Size(524, 279);
            this.Enployees_dataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "社員ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "社員名";
            this.Column2.Name = "Column2";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(201, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 41);
            this.button2.TabIndex = 45;
            this.button2.Text = "もどる";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(524, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 279);
            this.vScrollBar1.TabIndex = 0;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(32, 87);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(159, 19);
            this.Search_textBox.TabIndex = 18;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(110, 26);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(29, 12);
            this.Date_label.TabIndex = 43;
            this.Date_label.Text = "日付";
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Location = new System.Drawing.Point(33, 26);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(57, 12);
            this.UserName_label.TabIndex = 42;
            this.UserName_label.Text = "ユーザー名";
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Home_button.Image = global::SystemDevelop.Properties.Resources.touka_home1;
            this.Home_button.Location = new System.Drawing.Point(414, 12);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(88, 41);
            this.Home_button.TabIndex = 44;
            this.Home_button.Text = "ホーム";
            this.Home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Back_button.Location = new System.Drawing.Point(508, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(88, 41);
            this.Back_button.TabIndex = 45;
            this.Back_button.Text = "もどる";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // EnployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 491);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Search_textBox);
            this.Name = "EnployeesList";
            this.Text = "社員一覧";
            this.Load += new System.EventHandler(this.EnployeesList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Enployees_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Enployees_dataGridView;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Button Back_button;
    }
}