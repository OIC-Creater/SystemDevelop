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
            this.employeeList = new System.Windows.Forms.Button();
            this.manufacturerList = new System.Windows.Forms.Button();
            this.shopList = new System.Windows.Forms.Button();
            this.newProduct = new System.Windows.Forms.Button();
            this.businessOfficeList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeList.FlatAppearance.BorderSize = 0;
            this.employeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.employeeList.Location = new System.Drawing.Point(0, 0);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(216, 104);
            this.employeeList.TabIndex = 0;
            this.employeeList.Text = "社員一覧";
            this.employeeList.UseVisualStyleBackColor = true;
            this.employeeList.Click += new System.EventHandler(this.employeeList_Click);
            // 
            // manufacturerList
            // 
            this.manufacturerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manufacturerList.FlatAppearance.BorderSize = 0;
            this.manufacturerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manufacturerList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufacturerList.Location = new System.Drawing.Point(0, 104);
            this.manufacturerList.Name = "manufacturerList";
            this.manufacturerList.Size = new System.Drawing.Size(216, 104);
            this.manufacturerList.TabIndex = 1;
            this.manufacturerList.Text = "メーカ一覧";
            this.manufacturerList.UseVisualStyleBackColor = true;
            this.manufacturerList.Click += new System.EventHandler(this.manufacturerList_Click);
            // 
            // shopList
            // 
            this.shopList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopList.FlatAppearance.BorderSize = 0;
            this.shopList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shopList.Location = new System.Drawing.Point(0, 208);
            this.shopList.Name = "shopList";
            this.shopList.Size = new System.Drawing.Size(216, 104);
            this.shopList.TabIndex = 2;
            this.shopList.Text = "ショップ一覧";
            this.shopList.UseVisualStyleBackColor = true;
            this.shopList.Click += new System.EventHandler(this.shopList_Click);
            // 
            // newProduct
            // 
            this.newProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProduct.FlatAppearance.BorderSize = 0;
            this.newProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProduct.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.newProduct.Location = new System.Drawing.Point(0, 413);
            this.newProduct.Name = "newProduct";
            this.newProduct.Size = new System.Drawing.Size(216, 104);
            this.newProduct.TabIndex = 4;
            this.newProduct.Text = "新商品登録";
            this.newProduct.UseVisualStyleBackColor = true;
            this.newProduct.Click += new System.EventHandler(this.newProduct_Click);
            // 
            // businessOfficeList
            // 
            this.businessOfficeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.businessOfficeList.FlatAppearance.BorderSize = 0;
            this.businessOfficeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.businessOfficeList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.businessOfficeList.Location = new System.Drawing.Point(0, 309);
            this.businessOfficeList.Name = "businessOfficeList";
            this.businessOfficeList.Size = new System.Drawing.Size(216, 104);
            this.businessOfficeList.TabIndex = 3;
            this.businessOfficeList.Text = "営業所一覧";
            this.businessOfficeList.UseVisualStyleBackColor = true;
            this.businessOfficeList.Click += new System.EventHandler(this.businessOfficeList_Click);
            // 
            // MainOfficeManuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.businessOfficeList);
            this.Controls.Add(this.newProduct);
            this.Controls.Add(this.shopList);
            this.Controls.Add(this.manufacturerList);
            this.Controls.Add(this.employeeList);
            this.Name = "MainOfficeManuBar";
            this.Size = new System.Drawing.Size(216, 689);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button employeeList;
        public System.Windows.Forms.Button manufacturerList;
        public System.Windows.Forms.Button shopList;
        public System.Windows.Forms.Button newProduct;
        public System.Windows.Forms.Button businessOfficeList;
    }
}
