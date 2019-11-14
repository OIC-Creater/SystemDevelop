namespace SystemDevelop.Properties
{
    partial class AwardInput
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
            this.back_button = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.Date_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AwardInput_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ProductName_label = new System.Windows.Forms.Label();
            this.ProductId_label = new System.Windows.Forms.Label();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.Payment_label = new System.Windows.Forms.Label();
            this.Subtotal_label = new System.Windows.Forms.Label();
            this.Postage_label = new System.Windows.Forms.Label();
            this.ProductName_textBox = new System.Windows.Forms.TextBox();
            this.ProductId_textBox = new System.Windows.Forms.TextBox();
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.Payment_textBox = new System.Windows.Forms.TextBox();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.Postage_textBox = new System.Windows.Forms.TextBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AwardInput_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.back_button.Location = new System.Drawing.Point(514, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(88, 41);
            this.back_button.TabIndex = 51;
            this.back_button.Text = "もどる";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Home_button.Image = global::SystemDevelop.Properties.Resources.touka_home1;
            this.Home_button.Location = new System.Drawing.Point(420, 12);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(88, 41);
            this.Home_button.TabIndex = 50;
            this.Home_button.Text = "ホーム";
            this.Home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(116, 26);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(29, 12);
            this.Date_label.TabIndex = 49;
            this.Date_label.Text = "日付";
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Location = new System.Drawing.Point(39, 26);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(57, 12);
            this.UserName_label.TabIndex = 48;
            this.UserName_label.Text = "ユーザー名";
            this.UserName_label.Click += new System.EventHandler(this.UserNamelabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AwardInput_dataGridView);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(38, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 246);
            this.panel1.TabIndex = 47;
            // 
            // AwardInput_dataGridView
            // 
            this.AwardInput_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AwardInput_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.AwardInput_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AwardInput_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.AwardInput_dataGridView.Name = "AwardInput_dataGridView";
            this.AwardInput_dataGridView.RowTemplate.Height = 21;
            this.AwardInput_dataGridView.Size = new System.Drawing.Size(436, 246);
            this.AwardInput_dataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "数量";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "価格";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "小計";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
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
            this.vScrollBar1.Location = new System.Drawing.Point(436, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 246);
            this.vScrollBar1.TabIndex = 0;
            // 
            // ProductName_label
            // 
            this.ProductName_label.AutoSize = true;
            this.ProductName_label.Location = new System.Drawing.Point(39, 78);
            this.ProductName_label.Name = "ProductName_label";
            this.ProductName_label.Size = new System.Drawing.Size(41, 12);
            this.ProductName_label.TabIndex = 52;
            this.ProductName_label.Text = "商品名";
            // 
            // ProductId_label
            // 
            this.ProductId_label.AutoSize = true;
            this.ProductId_label.Location = new System.Drawing.Point(39, 102);
            this.ProductId_label.Name = "ProductId_label";
            this.ProductId_label.Size = new System.Drawing.Size(40, 12);
            this.ProductId_label.TabIndex = 53;
            this.ProductId_label.Text = "商品ID";
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.Location = new System.Drawing.Point(39, 127);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(29, 12);
            this.Quantity_label.TabIndex = 54;
            this.Quantity_label.Text = "数量";
            // 
            // Payment_label
            // 
            this.Payment_label.AutoSize = true;
            this.Payment_label.Location = new System.Drawing.Point(351, 82);
            this.Payment_label.Name = "Payment_label";
            this.Payment_label.Size = new System.Drawing.Size(63, 12);
            this.Payment_label.TabIndex = 55;
            this.Payment_label.Text = "お支払方法";
            // 
            // Subtotal_label
            // 
            this.Subtotal_label.AutoSize = true;
            this.Subtotal_label.Location = new System.Drawing.Point(385, 106);
            this.Subtotal_label.Name = "Subtotal_label";
            this.Subtotal_label.Size = new System.Drawing.Size(29, 12);
            this.Subtotal_label.TabIndex = 56;
            this.Subtotal_label.Text = "小計";
            // 
            // Postage_label
            // 
            this.Postage_label.AutoSize = true;
            this.Postage_label.Location = new System.Drawing.Point(385, 131);
            this.Postage_label.Name = "Postage_label";
            this.Postage_label.Size = new System.Drawing.Size(29, 12);
            this.Postage_label.TabIndex = 57;
            this.Postage_label.Text = "送料";
            // 
            // ProductName_textBox
            // 
            this.ProductName_textBox.Location = new System.Drawing.Point(86, 75);
            this.ProductName_textBox.Name = "ProductName_textBox";
            this.ProductName_textBox.Size = new System.Drawing.Size(100, 19);
            this.ProductName_textBox.TabIndex = 58;
            // 
            // ProductId_textBox
            // 
            this.ProductId_textBox.Location = new System.Drawing.Point(86, 99);
            this.ProductId_textBox.Name = "ProductId_textBox";
            this.ProductId_textBox.Size = new System.Drawing.Size(100, 19);
            this.ProductId_textBox.TabIndex = 59;
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(86, 124);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(100, 19);
            this.Quantity_textBox.TabIndex = 60;
            // 
            // Payment_textBox
            // 
            this.Payment_textBox.Location = new System.Drawing.Point(420, 75);
            this.Payment_textBox.Name = "Payment_textBox";
            this.Payment_textBox.Size = new System.Drawing.Size(100, 19);
            this.Payment_textBox.TabIndex = 61;
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(420, 100);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.Size = new System.Drawing.Size(100, 19);
            this.SubtotaltextBox.TabIndex = 62;
            // 
            // Postage_textBox
            // 
            this.Postage_textBox.Location = new System.Drawing.Point(420, 127);
            this.Postage_textBox.Name = "Postage_textBox";
            this.Postage_textBox.Size = new System.Drawing.Size(100, 19);
            this.Postage_textBox.TabIndex = 63;
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(503, 375);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(108, 43);
            this.Sendbutton.TabIndex = 64;
            this.Sendbutton.Text = "送信";
            this.Sendbutton.UseVisualStyleBackColor = true;
            // 
            // AwardInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 461);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Postage_textBox);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.Payment_textBox);
            this.Controls.Add(this.Quantity_textBox);
            this.Controls.Add(this.ProductId_textBox);
            this.Controls.Add(this.ProductName_textBox);
            this.Controls.Add(this.Postage_label);
            this.Controls.Add(this.Subtotal_label);
            this.Controls.Add(this.Payment_label);
            this.Controls.Add(this.Quantity_label);
            this.Controls.Add(this.ProductId_label);
            this.Controls.Add(this.ProductName_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.panel1);
            this.Name = "AwardInput";
            this.Text = "受注情報入力";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AwardInput_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView AwardInput_dataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label ProductName_label;
        private System.Windows.Forms.Label ProductId_label;
        private System.Windows.Forms.Label Quantity_label;
        private System.Windows.Forms.Label Payment_label;
        private System.Windows.Forms.Label Subtotal_label;
        private System.Windows.Forms.Label Postage_label;
        private System.Windows.Forms.TextBox ProductName_textBox;
        private System.Windows.Forms.TextBox ProductId_textBox;
        private System.Windows.Forms.TextBox Quantity_textBox;
        private System.Windows.Forms.TextBox Payment_textBox;
        private System.Windows.Forms.TextBox SubtotaltextBox;
        private System.Windows.Forms.TextBox Postage_textBox;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}