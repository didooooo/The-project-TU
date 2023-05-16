namespace The_project
{
    partial class Login
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
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.pnlChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChoose
            // 
            this.pnlChoose.Controls.Add(this.btnLogin);
            this.pnlChoose.Controls.Add(this.btnGuest);
            this.pnlChoose.Location = new System.Drawing.Point(91, 61);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(613, 341);
            this.pnlChoose.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Image = global::The_project.Properties.Resources.output_onlinegiftools;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(415, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(285, 115);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuest.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuest.ForeColor = System.Drawing.Color.White;
            this.btnGuest.Image = global::The_project.Properties.Resources.output_onlinegiftools;
            this.btnGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuest.Location = new System.Drawing.Point(124, 190);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(285, 115);
            this.btnGuest.TabIndex = 0;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginPanel.Controls.Add(this.btnlog);
            this.loginPanel.Controls.Add(this.textBoxpasswordL);
            this.loginPanel.Controls.Add(this.textBoxemailL);
            this.loginPanel.Controls.Add(this.signUpLabel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Location = new System.Drawing.Point(79, 56);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(830, 553);
            this.loginPanel.TabIndex = 1;
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.SystemColors.Control;
            this.btnlog.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnlog.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlog.Image = global::The_project.Properties.Resources.output_onlinegiftools;
            this.btnlog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlog.Location = new System.Drawing.Point(298, 345);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(244, 49);
            this.btnlog.TabIndex = 6;
            this.btnlog.Text = "Log in";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // textBoxpasswordL
            // 
            this.textBoxpasswordL.Location = new System.Drawing.Point(293, 261);
            this.textBoxpasswordL.Name = "textBoxpasswordL";
            this.textBoxpasswordL.PasswordChar = '$';
            this.textBoxpasswordL.PlaceholderText = "Password";
            this.textBoxpasswordL.Size = new System.Drawing.Size(271, 31);
            this.textBoxpasswordL.TabIndex = 5;
            this.textBoxpasswordL.UseSystemPasswordChar = true;
            // 
            // textBoxemailL
            // 
            this.textBoxemailL.Location = new System.Drawing.Point(293, 217);
            this.textBoxemailL.Name = "textBoxemailL";
            this.textBoxemailL.PlaceholderText = "Username";
            this.textBoxemailL.Size = new System.Drawing.Size(271, 31);
            this.textBoxemailL.TabIndex = 4;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpLabel.Location = new System.Drawing.Point(447, 93);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(244, 68);
            this.signUpLabel.TabIndex = 1;
            this.signUpLabel.Text = "SIGN UP";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Showcard Gothic", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(159, 71);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(281, 94);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "LOG IN";
            // 
            // signUpPanel
            // 
            this.signUpPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signUpPanel.Controls.Add(this.textBoxSName);
            this.signUpPanel.Controls.Add(this.textBoxConfirmPass);
            this.signUpPanel.Controls.Add(this.btnSignUpinSignUp);
            this.signUpPanel.Controls.Add(this.textBoxpasswordS);
            this.signUpPanel.Controls.Add(this.textBoxemailS);
            this.signUpPanel.Controls.Add(this.ssignUpLabel);
            this.signUpPanel.Controls.Add(this.lloginLabel);
            this.signUpPanel.Location = new System.Drawing.Point(81, 51);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(830, 553);
            this.signUpPanel.TabIndex = 7;
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(280, 185);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.PlaceholderText = "Name";
            this.textBoxSName.Size = new System.Drawing.Size(271, 31);
            this.textBoxSName.TabIndex = 12;
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Location = new System.Drawing.Point(280, 368);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.PasswordChar = '$';
            this.textBoxConfirmPass.PlaceholderText = "Confirm password";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(271, 31);
            this.textBoxConfirmPass.TabIndex = 8;
            // 
            // btnSignUpinSignUp
            // 
            this.btnSignUpinSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignUpinSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUpinSignUp.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUpinSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUpinSignUp.Image = global::The_project.Properties.Resources.output_onlinegiftools;
            this.btnSignUpinSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignUpinSignUp.Location = new System.Drawing.Point(290, 467);
            this.btnSignUpinSignUp.Name = "btnSignUpinSignUp";
            this.btnSignUpinSignUp.Size = new System.Drawing.Size(244, 49);
            this.btnSignUpinSignUp.TabIndex = 6;
            this.btnSignUpinSignUp.Text = "Sign up";
            this.btnSignUpinSignUp.UseVisualStyleBackColor = false;
            this.btnSignUpinSignUp.Click += new System.EventHandler(this.btnSignUpinSignUp_Click);
            // 
            // textBoxpasswordS
            // 
            this.textBoxpasswordS.Location = new System.Drawing.Point(280, 313);
            this.textBoxpasswordS.Name = "textBoxpasswordS";
            this.textBoxpasswordS.PasswordChar = '$';
            this.textBoxpasswordS.PlaceholderText = "Password";
            this.textBoxpasswordS.Size = new System.Drawing.Size(271, 31);
            this.textBoxpasswordS.TabIndex = 5;
            // 
            // textBoxemailS
            // 
            this.textBoxemailS.Location = new System.Drawing.Point(280, 249);
            this.textBoxemailS.Name = "textBoxemailS";
            this.textBoxemailS.PlaceholderText = "Email";
            this.textBoxemailS.Size = new System.Drawing.Size(271, 31);
            this.textBoxemailS.TabIndex = 4;
            // 
            // ssignUpLabel
            // 
            this.ssignUpLabel.AutoSize = true;
            this.ssignUpLabel.Font = new System.Drawing.Font("Showcard Gothic", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ssignUpLabel.Location = new System.Drawing.Point(422, 71);
            this.ssignUpLabel.Name = "ssignUpLabel";
            this.ssignUpLabel.Size = new System.Drawing.Size(330, 94);
            this.ssignUpLabel.TabIndex = 1;
            this.ssignUpLabel.Text = "SIGN UP";
            // 
            // lloginLabel
            // 
            this.lloginLabel.AutoSize = true;
            this.lloginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lloginLabel.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lloginLabel.Location = new System.Drawing.Point(189, 93);
            this.lloginLabel.Name = "lloginLabel";
            this.lloginLabel.Size = new System.Drawing.Size(195, 68);
            this.lloginLabel.TabIndex = 0;
            this.lloginLabel.Text = "LOGIN";
            this.lloginLabel.Click += new System.EventHandler(this.lloginLabel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 664);
            this.Controls.Add(this.signUpPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.pnlChoose);
            this.Name = "Login";
            this.Text = "Login";
            this.pnlChoose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlChoose;
        private Button btnLogin;
        private Button btnGuest;
    }
}