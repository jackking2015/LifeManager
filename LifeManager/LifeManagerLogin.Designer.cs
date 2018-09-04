namespace LifeManager
{
    partial class LifeManagerLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassWord = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.rbSavePassword = new System.Windows.Forms.RadioButton();
            this.rbAutoLogin = new System.Windows.Forms.RadioButton();
            this.btLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.SystemColors.Control;
            this.labelUserName.Location = new System.Drawing.Point(100, 132);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(62, 18);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "用户名";
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.BackColor = System.Drawing.SystemColors.Control;
            this.labelPassWord.Location = new System.Drawing.Point(100, 200);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(44, 18);
            this.labelPassWord.TabIndex = 1;
            this.labelPassWord.Text = "密码";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(199, 127);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(172, 28);
            this.tbUserName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(199, 195);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(172, 28);
            this.tbPassword.TabIndex = 3;
            // 
            // rbSavePassword
            // 
            this.rbSavePassword.AutoSize = true;
            this.rbSavePassword.BackColor = System.Drawing.SystemColors.Control;
            this.rbSavePassword.Location = new System.Drawing.Point(103, 244);
            this.rbSavePassword.Name = "rbSavePassword";
            this.rbSavePassword.Size = new System.Drawing.Size(105, 22);
            this.rbSavePassword.TabIndex = 4;
            this.rbSavePassword.TabStop = true;
            this.rbSavePassword.Text = "记住密码";
            this.rbSavePassword.UseVisualStyleBackColor = false;
            // 
            // rbAutoLogin
            // 
            this.rbAutoLogin.AutoSize = true;
            this.rbAutoLogin.BackColor = System.Drawing.SystemColors.Control;
            this.rbAutoLogin.Location = new System.Drawing.Point(266, 244);
            this.rbAutoLogin.Name = "rbAutoLogin";
            this.rbAutoLogin.Size = new System.Drawing.Size(105, 22);
            this.rbAutoLogin.TabIndex = 5;
            this.rbAutoLogin.TabStop = true;
            this.rbAutoLogin.Text = "自动登陆";
            this.rbAutoLogin.UseVisualStyleBackColor = false;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btLogin.Location = new System.Drawing.Point(103, 305);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(268, 40);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "登陆";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // LifeManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 416);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.rbAutoLogin);
            this.Controls.Add(this.rbSavePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.labelPassWord);
            this.Controls.Add(this.labelUserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LifeManagerLogin";
            this.Text = "LifeManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.RadioButton rbSavePassword;
        private System.Windows.Forms.RadioButton rbAutoLogin;
        private System.Windows.Forms.Button btLogin;
    }
}

