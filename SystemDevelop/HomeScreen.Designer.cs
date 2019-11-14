namespace SystemDevelop
{
    partial class HomeScreen
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
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.LogList = new System.Windows.Forms.Button();
            this.MakerList = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.Button();
            this.EmployeesList = new System.Windows.Forms.Button();
            this.UndispatchedList = new System.Windows.Forms.Button();
            this.ManufacturerOrderList = new System.Windows.Forms.Button();
            this.ShopList = new System.Windows.Forms.Button();
            this.AwardInput = new System.Windows.Forms.Button();
            this.StockList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(12, 32);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(57, 12);
            this.UserNamelabel.TabIndex = 13;
            this.UserNamelabel.Text = "ユーザー名";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Location = new System.Drawing.Point(75, 32);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(29, 12);
            this.Datelabel.TabIndex = 14;
            this.Datelabel.Text = "日付";
            // 
            // LogList
            // 
            this.LogList.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LogList.Image = global::SystemDevelop.Properties.Resources.touka_log;
            this.LogList.Location = new System.Drawing.Point(73, 379);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(125, 59);
            this.LogList.TabIndex = 12;
            this.LogList.Text = "ログ";
            this.LogList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogList.UseVisualStyleBackColor = true;
            this.LogList.Click += new System.EventHandler(this.LogList_Click);
            // 
            // MakerList
            // 
            this.MakerList.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MakerList.Image = global::SystemDevelop.Properties.Resources.touka_maker1;
            this.MakerList.Location = new System.Drawing.Point(215, 292);
            this.MakerList.Name = "MakerList";
            this.MakerList.Size = new System.Drawing.Size(125, 59);
            this.MakerList.TabIndex = 11;
            this.MakerList.Text = "メーカ一覧";
            this.MakerList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MakerList.UseVisualStyleBackColor = true;
            this.MakerList.Click += new System.EventHandler(this.MakerList_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Logout.Image = global::SystemDevelop.Properties.Resources.touka_logout;
            this.Logout.Location = new System.Drawing.Point(530, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(126, 52);
            this.Logout.TabIndex = 10;
            this.Logout.TabStop = false;
            this.Logout.Text = "ログアウト";
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.button9_Click);
            // 
            // ProductList
            // 
            this.ProductList.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProductList.Image = global::SystemDevelop.Properties.Resources.touka_product;
            this.ProductList.Location = new System.Drawing.Point(73, 90);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(125, 59);
            this.ProductList.TabIndex = 5;
            this.ProductList.Text = "商品一覧";
            this.ProductList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductList.UseVisualStyleBackColor = true;
            this.ProductList.Click += new System.EventHandler(this.ProductList_Click);
            // 
            // EmployeesList
            // 
            this.EmployeesList.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EmployeesList.Image = global::SystemDevelop.Properties.Resources.touka_emp;
            this.EmployeesList.Location = new System.Drawing.Point(356, 292);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(125, 59);
            this.EmployeesList.TabIndex = 4;
            this.EmployeesList.Text = "社員一覧";
            this.EmployeesList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeesList.UseVisualStyleBackColor = true;
            this.EmployeesList.Click += new System.EventHandler(this.button5_Click);
            // 
            // UndispatchedList
            // 
            this.UndispatchedList.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UndispatchedList.Image = global::SystemDevelop.Properties.Resources.touka_post1;
            this.UndispatchedList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UndispatchedList.Location = new System.Drawing.Point(356, 189);
            this.UndispatchedList.Name = "UndispatchedList";
            this.UndispatchedList.Size = new System.Drawing.Size(125, 59);
            this.UndispatchedList.TabIndex = 7;
            this.UndispatchedList.Text = "未発送一覧";
            this.UndispatchedList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UndispatchedList.UseVisualStyleBackColor = true;
            this.UndispatchedList.Click += new System.EventHandler(this.UndispatchedList_Click);
            // 
            // ManufacturerOrderList
            // 
            this.ManufacturerOrderList.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ManufacturerOrderList.Image = global::SystemDevelop.Properties.Resources.touka_shipping;
            this.ManufacturerOrderList.Location = new System.Drawing.Point(215, 188);
            this.ManufacturerOrderList.Name = "ManufacturerOrderList";
            this.ManufacturerOrderList.Size = new System.Drawing.Size(125, 59);
            this.ManufacturerOrderList.TabIndex = 6;
            this.ManufacturerOrderList.Text = "発注一覧";
            this.ManufacturerOrderList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManufacturerOrderList.UseVisualStyleBackColor = true;
            this.ManufacturerOrderList.Click += new System.EventHandler(this.ManufacturerOrderList_Click);
            // 
            // ShopList
            // 
            this.ShopList.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShopList.Image = global::SystemDevelop.Properties.Resources.touka_shop2;
            this.ShopList.Location = new System.Drawing.Point(74, 292);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(126, 57);
            this.ShopList.TabIndex = 1;
            this.ShopList.Text = "ショップ一覧";
            this.ShopList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShopList.UseVisualStyleBackColor = true;
            this.ShopList.Click += new System.EventHandler(this.ShopList_Click);
            // 
            // AwardInput
            // 
            this.AwardInput.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AwardInput.Image = global::SystemDevelop.Properties.Resources.touka_order;
            this.AwardInput.Location = new System.Drawing.Point(74, 189);
            this.AwardInput.Name = "AwardInput";
            this.AwardInput.Size = new System.Drawing.Size(125, 57);
            this.AwardInput.TabIndex = 2;
            this.AwardInput.Text = "受注情報";
            this.AwardInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AwardInput.UseVisualStyleBackColor = true;
            this.AwardInput.Click += new System.EventHandler(this.AwardInput_Click);
            // 
            // StockList
            // 
            this.StockList.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StockList.Image = global::SystemDevelop.Properties.Resources.touka_souko;
            this.StockList.Location = new System.Drawing.Point(215, 90);
            this.StockList.Name = "StockList";
            this.StockList.Size = new System.Drawing.Size(125, 59);
            this.StockList.TabIndex = 3;
            this.StockList.Text = "在庫一覧";
            this.StockList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StockList.UseVisualStyleBackColor = true;
            this.StockList.Click += new System.EventHandler(this.StockList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 465);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.LogList);
            this.Controls.Add(this.MakerList);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.EmployeesList);
            this.Controls.Add(this.UndispatchedList);
            this.Controls.Add(this.ManufacturerOrderList);
            this.Controls.Add(this.ShopList);
            this.Controls.Add(this.AwardInput);
            this.Controls.Add(this.StockList);
            this.Name = "HomeScreen";
            this.Text = "トップ";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShopList;
        private System.Windows.Forms.Button EmployeesList;
        private System.Windows.Forms.Button AwardInput;
        private System.Windows.Forms.Button StockList;
        private System.Windows.Forms.Button ManufacturerOrderList;
        private System.Windows.Forms.Button ProductList;
        private System.Windows.Forms.Button UndispatchedList;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button MakerList;
        private System.Windows.Forms.Button LogList;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}