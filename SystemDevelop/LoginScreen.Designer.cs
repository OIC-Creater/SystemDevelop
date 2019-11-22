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
            this.login_button = new System.Windows.Forms.Button();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.emp_id_lbl = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.login_button.Location = new System.Drawing.Point(499, 340);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(500, 64);
            this.login_button.TabIndex = 9;
            this.login_button.Text = "ログイン";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passWordTextBox.Location = new System.Drawing.Point(499, 264);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.PasswordChar = '*';
            this.passWordTextBox.Size = new System.Drawing.Size(500, 23);
            this.passWordTextBox.TabIndex = 8;
            this.passWordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passWordTextBox_KeyDown);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password_lbl.Location = new System.Drawing.Point(379, 264);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(114, 19);
            this.password_lbl.TabIndex = 6;
            this.password_lbl.Text = "パスワード";
            // 
            // emp_id_lbl
            // 
            this.emp_id_lbl.AutoSize = true;
            this.emp_id_lbl.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emp_id_lbl.Location = new System.Drawing.Point(417, 201);
            this.emp_id_lbl.Name = "emp_id_lbl";
            this.emp_id_lbl.Size = new System.Drawing.Size(69, 19);
            this.emp_id_lbl.TabIndex = 5;
            this.emp_id_lbl.Text = "社員ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idTextBox.Location = new System.Drawing.Point(499, 201);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(500, 23);
            this.idTextBox.TabIndex = 7;
            this.idTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idTextBox_KeyDown);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.emp_id_lbl);
            this.HelpButton = true;
            this.Name = "LoginScreen";
            this.Text = "ログイン画面";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label emp_id_lbl;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

