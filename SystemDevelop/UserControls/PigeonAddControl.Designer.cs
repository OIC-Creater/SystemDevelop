namespace SystemDevelop.UserControls
{
    partial class PigeonAddControl
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.pigeonID = new System.Windows.Forms.Label();
            this.pigeonNameTextBox = new System.Windows.Forms.TextBox();
            this.manufactureAddButton = new System.Windows.Forms.Button();
            this.pigeonName = new System.Windows.Forms.Label();
            this.pigeonIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pigeonStutasID = new System.Windows.Forms.Label();
            this.pigeonKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cancelButton.Location = new System.Drawing.Point(573, 651);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(153, 43);
            this.cancelButton.TabIndex = 67;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // pigeonID
            // 
            this.pigeonID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonID.AutoSize = true;
            this.pigeonID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonID.Location = new System.Drawing.Point(397, 95);
            this.pigeonID.Name = "pigeonID";
            this.pigeonID.Size = new System.Drawing.Size(117, 33);
            this.pigeonID.TabIndex = 66;
            this.pigeonID.Text = "id_label";
            // 
            // pigeonNameTextBox
            // 
            this.pigeonNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pigeonNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonNameTextBox.Location = new System.Drawing.Point(403, 233);
            this.pigeonNameTextBox.Name = "pigeonNameTextBox";
            this.pigeonNameTextBox.Size = new System.Drawing.Size(398, 39);
            this.pigeonNameTextBox.TabIndex = 65;
            // 
            // manufactureAddButton
            // 
            this.manufactureAddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.manufactureAddButton.AutoSize = true;
            this.manufactureAddButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.manufactureAddButton.Location = new System.Drawing.Point(751, 651);
            this.manufactureAddButton.Name = "manufactureAddButton";
            this.manufactureAddButton.Size = new System.Drawing.Size(104, 43);
            this.manufactureAddButton.TabIndex = 62;
            this.manufactureAddButton.Text = "登録";
            this.manufactureAddButton.UseVisualStyleBackColor = true;
            // 
            // pigeonName
            // 
            this.pigeonName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonName.AutoSize = true;
            this.pigeonName.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonName.Location = new System.Drawing.Point(178, 236);
            this.pigeonName.Name = "pigeonName";
            this.pigeonName.Size = new System.Drawing.Size(100, 33);
            this.pigeonName.TabIndex = 60;
            this.pigeonName.Text = "ハト名";
            // 
            // pigeonIDLabel
            // 
            this.pigeonIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonIDLabel.AutoSize = true;
            this.pigeonIDLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonIDLabel.Location = new System.Drawing.Point(178, 95);
            this.pigeonIDLabel.Name = "pigeonIDLabel";
            this.pigeonIDLabel.Size = new System.Drawing.Size(98, 33);
            this.pigeonIDLabel.TabIndex = 58;
            this.pigeonIDLabel.Text = "ハトID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(178, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 68;
            this.label1.Text = "ステータスID";
            // 
            // pigeonStutasID
            // 
            this.pigeonStutasID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonStutasID.AutoSize = true;
            this.pigeonStutasID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonStutasID.Location = new System.Drawing.Point(397, 538);
            this.pigeonStutasID.Name = "pigeonStutasID";
            this.pigeonStutasID.Size = new System.Drawing.Size(117, 33);
            this.pigeonStutasID.TabIndex = 69;
            this.pigeonStutasID.Text = "id_label";
            // 
            // pigeonKey
            // 
            this.pigeonKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pigeonKey.AutoSize = true;
            this.pigeonKey.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pigeonKey.Location = new System.Drawing.Point(397, 393);
            this.pigeonKey.Name = "pigeonKey";
            this.pigeonKey.Size = new System.Drawing.Size(114, 33);
            this.pigeonKey.TabIndex = 71;
            this.pigeonKey.Text = "公開鍵";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(178, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 33);
            this.label4.TabIndex = 70;
            this.label4.Text = "公開鍵";
            // 
            // PigeonAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pigeonKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pigeonStutasID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pigeonID);
            this.Controls.Add(this.pigeonNameTextBox);
            this.Controls.Add(this.manufactureAddButton);
            this.Controls.Add(this.pigeonName);
            this.Controls.Add(this.pigeonIDLabel);
            this.Name = "PigeonAddControl";
            this.Size = new System.Drawing.Size(1033, 789);
            this.Load += new System.EventHandler(this.PigeonAddControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label pigeonID;
        private System.Windows.Forms.TextBox pigeonNameTextBox;
        public System.Windows.Forms.Button manufactureAddButton;
        private System.Windows.Forms.Label pigeonName;
        private System.Windows.Forms.Label pigeonIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pigeonStutasID;
        private System.Windows.Forms.Label pigeonKey;
        private System.Windows.Forms.Label label4;
    }
}
