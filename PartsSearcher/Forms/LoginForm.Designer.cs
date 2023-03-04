namespace PartsSearcher.Forms
{
    partial class LoginForm
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
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.autologinButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(134, 22);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(170, 23);
			this.usernameBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Имя пользователя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пароль";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(134, 51);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(170, 23);
			this.passwordBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(0, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(384, 27);
			this.label3.TabIndex = 1;
			this.label3.Text = "База деталей";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// autologinButton
			// 
			this.autologinButton.Location = new System.Drawing.Point(27, 42);
			this.autologinButton.Name = "autologinButton";
			this.autologinButton.Size = new System.Drawing.Size(323, 25);
			this.autologinButton.TabIndex = 4;
			this.autologinButton.Text = "Открыть для просмотра";
			this.autologinButton.UseVisualStyleBackColor = true;
			this.autologinButton.Click += new System.EventHandler(this.autologinButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.passwordBox);
			this.groupBox1.Controls.Add(this.loginButton);
			this.groupBox1.Controls.Add(this.usernameBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(27, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(323, 126);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Или войти";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(134, 83);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(170, 25);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Войти";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.autologinButton);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "База деталей - Вход";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private TextBox usernameBox;
        private Label label1;
        private Label label2;
        private TextBox passwordBox;
        private Label label3;
        private Button autologinButton;
        private GroupBox groupBox1;
        private Button loginButton;
    }
}