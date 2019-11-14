namespace SystemDevelop.Properties
{
    partial class StockAdd
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
            this.Add_button = new System.Windows.Forms.Button();
            this.Stock_textBox = new System.Windows.Forms.TextBox();
            this.ProductCode_textBox = new System.Windows.Forms.TextBox();
            this.Stock_label = new System.Windows.Forms.Label();
            this.ProductCode_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.Date_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Home_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Add_button.Location = new System.Drawing.Point(425, 264);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(97, 45);
            this.Add_button.TabIndex = 42;
            this.Add_button.Text = "追加";
            this.Add_button.UseVisualStyleBackColor = true;
            // 
            // Stock_textBox
            // 
            this.Stock_textBox.Location = new System.Drawing.Point(141, 135);
            this.Stock_textBox.Name = "Stock_textBox";
            this.Stock_textBox.Size = new System.Drawing.Size(172, 19);
            this.Stock_textBox.TabIndex = 39;
            // 
            // ProductCode_textBox
            // 
            this.ProductCode_textBox.Location = new System.Drawing.Point(141, 90);
            this.ProductCode_textBox.Name = "ProductCode_textBox";
            this.ProductCode_textBox.Size = new System.Drawing.Size(172, 19);
            this.ProductCode_textBox.TabIndex = 38;
            // 
            // Stock_label
            // 
            this.Stock_label.AutoSize = true;
            this.Stock_label.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Stock_label.Location = new System.Drawing.Point(33, 138);
            this.Stock_label.Name = "Stock_label";
            this.Stock_label.Size = new System.Drawing.Size(41, 12);
            this.Stock_label.TabIndex = 35;
            this.Stock_label.Text = "在庫数";
            // 
            // ProductCode_label
            // 
            this.ProductCode_label.AutoSize = true;
            this.ProductCode_label.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProductCode_label.Location = new System.Drawing.Point(33, 93);
            this.ProductCode_label.Name = "ProductCode_label";
            this.ProductCode_label.Size = new System.Drawing.Size(65, 12);
            this.ProductCode_label.TabIndex = 34;
            this.ProductCode_label.Text = "商品コード";
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.back_button.Location = new System.Drawing.Point(434, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(88, 41);
            this.back_button.TabIndex = 33;
            this.back_button.Text = "もどる";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(110, 26);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(29, 12);
            this.Date_label.TabIndex = 31;
            this.Date_label.Text = "日付";
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Location = new System.Drawing.Point(33, 26);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(57, 12);
            this.UserName_label.TabIndex = 30;
            this.UserName_label.Text = "ユーザー名";
            // 
            // Home_button
            // 
            this.Home_button.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Home_button.Image = global::SystemDevelop.Properties.Resources.touka_home1;
            this.Home_button.Location = new System.Drawing.Point(340, 12);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(88, 41);
            this.Home_button.TabIndex = 32;
            this.Home_button.Text = "ホーム";
            this.Home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_button.UseVisualStyleBackColor = true;
            // 
            // StockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 321);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Stock_textBox);
            this.Controls.Add(this.ProductCode_textBox);
            this.Controls.Add(this.Stock_label);
            this.Controls.Add(this.ProductCode_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.UserName_label);
            this.Name = "StockAdd";
            this.Text = "在庫追加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox Stock_textBox;
        private System.Windows.Forms.TextBox ProductCode_textBox;
        private System.Windows.Forms.Label Stock_label;
        private System.Windows.Forms.Label ProductCode_label;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label UserName_label;
    }
}