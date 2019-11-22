namespace SystemDevelop
{
    partial class LoginScreen
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuControl = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuControl.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuControl
            // 
            this.menuControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.menuControl.Controls.Add(this.loginPage);
            this.menuControl.Controls.Add(this.stockPage);
            this.menuControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.menuControl.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuControl.ItemSize = new System.Drawing.Size(350, 200);
            this.menuControl.Location = new System.Drawing.Point(0, 0);
            this.menuControl.Margin = new System.Windows.Forms.Padding(0);
            this.menuControl.Multiline = true;
            this.menuControl.Name = "menuControl";
            this.menuControl.SelectedIndex = 0;
            this.menuControl.Size = new System.Drawing.Size(1264, 681);
            this.menuControl.TabIndex = 10;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.loginButton);
            this.loginPage.Controls.Add(this.passTextBox);
            this.loginPage.Controls.Add(this.idTextBox);
            this.loginPage.Controls.Add(this.label1);
            this.loginPage.Controls.Add(this.idLabel);
            this.loginPage.Location = new System.Drawing.Point(204, 4);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(1056, 673);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "login";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.label2);
            this.stockPage.Location = new System.Drawing.Point(204, 4);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(1056, 673);
            this.stockPage.TabIndex = 1;
            this.stockPage.Text = "在庫";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(371, 454);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(294, 68);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "ログイン";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passTextBox.Location = new System.Drawing.Point(450, 300);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(399, 44);
            this.passTextBox.TabIndex = 13;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idTextBox.Location = new System.Drawing.Point(450, 151);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(399, 44);
            this.idTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(207, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "パスワード";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idLabel.Location = new System.Drawing.Point(208, 151);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(127, 35);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "社員ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(287, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 97);
            this.label2.TabIndex = 0;
            this.label2.Text = "HogeHuga";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "LoginScreen";
            this.Text = "ログイン画面";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.menuControl.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.stockPage.ResumeLayout(false);
            this.stockPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuControl;
        private System.Windows.Forms.TabPage loginPage;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label2;
    }
}

