namespace SystemDevelop.UserControls
{
    partial class MainOfficeManuBar
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
            this.employeeListButton = new System.Windows.Forms.Button();
            this.manufacturerListButton = new System.Windows.Forms.Button();
            this.shopListButton = new System.Windows.Forms.Button();
            this.newProductButton = new System.Windows.Forms.Button();
            this.businessOfficeListButton = new System.Windows.Forms.Button();
            this.productListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeListButton
            // 
            this.employeeListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeListButton.FlatAppearance.BorderSize = 0;
            this.employeeListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.employeeListButton.Location = new System.Drawing.Point(0, 0);
            this.employeeListButton.Name = "employeeListButton";
            this.employeeListButton.Size = new System.Drawing.Size(216, 104);
            this.employeeListButton.TabIndex = 0;
            this.employeeListButton.Text = "社員一覧";
            this.employeeListButton.UseVisualStyleBackColor = true;
            this.employeeListButton.Click += new System.EventHandler(this.employeeList_Click);
            // 
            // manufacturerListButton
            // 
            this.manufacturerListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manufacturerListButton.FlatAppearance.BorderSize = 0;
            this.manufacturerListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturerListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufacturerListButton.Location = new System.Drawing.Point(0, 104);
            this.manufacturerListButton.Name = "manufacturerListButton";
            this.manufacturerListButton.Size = new System.Drawing.Size(216, 104);
            this.manufacturerListButton.TabIndex = 1;
            this.manufacturerListButton.Text = "メーカ一覧";
            this.manufacturerListButton.UseVisualStyleBackColor = true;
            this.manufacturerListButton.Click += new System.EventHandler(this.manufacturerList_Click);
            // 
            // shopListButton
            // 
            this.shopListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopListButton.FlatAppearance.BorderSize = 0;
            this.shopListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopListButton.Location = new System.Drawing.Point(0, 208);
            this.shopListButton.Name = "shopListButton";
            this.shopListButton.Size = new System.Drawing.Size(216, 104);
            this.shopListButton.TabIndex = 2;
            this.shopListButton.Text = "ショップ一覧";
            this.shopListButton.UseVisualStyleBackColor = true;
            this.shopListButton.Click += new System.EventHandler(this.shopList_Click);
            // 
            // newProductButton
            // 
            this.newProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProductButton.FlatAppearance.BorderSize = 0;
            this.newProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProductButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.newProductButton.Location = new System.Drawing.Point(0, 413);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(216, 104);
            this.newProductButton.TabIndex = 4;
            this.newProductButton.Text = "新商品登録";
            this.newProductButton.UseVisualStyleBackColor = true;
            this.newProductButton.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // businessOfficeListButton
            // 
            this.businessOfficeListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.businessOfficeListButton.FlatAppearance.BorderSize = 0;
            this.businessOfficeListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.businessOfficeListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.businessOfficeListButton.Location = new System.Drawing.Point(0, 309);
            this.businessOfficeListButton.Name = "businessOfficeListButton";
            this.businessOfficeListButton.Size = new System.Drawing.Size(216, 104);
            this.businessOfficeListButton.TabIndex = 3;
            this.businessOfficeListButton.Text = "営業所一覧";
            this.businessOfficeListButton.UseVisualStyleBackColor = true;
            this.businessOfficeListButton.Click += new System.EventHandler(this.businessOfficeList_Click);
            // 
            // productListButton
            // 
            this.productListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListButton.FlatAppearance.BorderSize = 0;
            this.productListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productListButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productListButton.Location = new System.Drawing.Point(0, 517);
            this.productListButton.Name = "productListButton";
            this.productListButton.Size = new System.Drawing.Size(216, 104);
            this.productListButton.TabIndex = 5;
            this.productListButton.Text = "商品一覧";
            this.productListButton.UseVisualStyleBackColor = true;
            // 
            // MainOfficeManuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productListButton);
            this.Controls.Add(this.businessOfficeListButton);
            this.Controls.Add(this.newProductButton);
            this.Controls.Add(this.shopListButton);
            this.Controls.Add(this.manufacturerListButton);
            this.Controls.Add(this.employeeListButton);
            this.Name = "MainOfficeManuBar";
            this.Size = new System.Drawing.Size(216, 689);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button employeeListButton;
        public System.Windows.Forms.Button manufacturerListButton;
        public System.Windows.Forms.Button shopListButton;
        public System.Windows.Forms.Button newProductButton;
        public System.Windows.Forms.Button businessOfficeListButton;
        public System.Windows.Forms.Button productListButton;
    }
}
