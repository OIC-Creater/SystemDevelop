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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.emp_id_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.login_button.Location = new System.Drawing.Point(132, 186);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(205, 43);
            this.login_button.TabIndex = 9;
            this.login_button.Text = "ログイン";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(132, 38);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(205, 31);
            this.idTextBox.TabIndex = 7;
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(132, 103);
            this.passWordTextBox.Multiline = true;
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.PasswordChar = '*';
            this.passWordTextBox.Size = new System.Drawing.Size(205, 31);
            this.passWordTextBox.TabIndex = 8;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password_lbl.Location = new System.Drawing.Point(12, 110);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(114, 19);
            this.password_lbl.TabIndex = 6;
            this.password_lbl.Text = "パスワード";
            // 
            // emp_id_lbl
            // 
            this.emp_id_lbl.AutoSize = true;
            this.emp_id_lbl.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emp_id_lbl.Location = new System.Drawing.Point(50, 47);
            this.emp_id_lbl.Name = "emp_id_lbl";
            this.emp_id_lbl.Size = new System.Drawing.Size(69, 19);
            this.emp_id_lbl.TabIndex = 5;
            this.emp_id_lbl.Text = "社員ID";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 265);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.emp_id_lbl);
            this.Name = "LoginScreen";
            this.Text = "ログイン画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label emp_id_lbl;
    }
}

