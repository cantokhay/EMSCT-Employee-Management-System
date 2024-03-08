namespace EMSCT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btn__login_signup = new Button();
            label5 = new Label();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            tbx_login_username = new TextBox();
            label4 = new Label();
            tbx_login_password = new TextBox();
            cbx_login_Password = new CheckBox();
            btn_login_signin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn__login_signup);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 400);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = UI.Properties.Resources.Employment_PNG_Clipart;
            pictureBox1.Location = new Point(61, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(11, 138);
            label6.Name = "label6";
            label6.Size = new Size(216, 18);
            label6.TabIndex = 2;
            label6.Text = "Employee Management System";
            // 
            // btn__login_signup
            // 
            btn__login_signup.BackColor = Color.FromArgb(33, 11, 97);
            btn__login_signup.Cursor = Cursors.Hand;
            btn__login_signup.FlatAppearance.BorderSize = 0;
            btn__login_signup.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn__login_signup.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn__login_signup.FlatStyle = FlatStyle.Flat;
            btn__login_signup.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn__login_signup.ForeColor = Color.White;
            btn__login_signup.Location = new Point(33, 353);
            btn__login_signup.Name = "btn__login_signup";
            btn__login_signup.Size = new Size(169, 34);
            btn__login_signup.TabIndex = 1;
            btn__login_signup.Text = "SIGN UP";
            btn__login_signup.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(49, 336);
            label5.Name = "label5";
            label5.Size = new Size(130, 14);
            label5.TabIndex = 0;
            label5.Text = "Register New Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exit.Location = new Point(556, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(280, 87);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(280, 152);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 3;
            label3.Text = "UserName :";
            // 
            // tbx_login_username
            // 
            tbx_login_username.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_login_username.Location = new Point(280, 171);
            tbx_login_username.Name = "tbx_login_username";
            tbx_login_username.Size = new Size(268, 26);
            tbx_login_username.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(280, 224);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 3;
            label4.Text = "Password :";
            // 
            // tbx_login_password
            // 
            tbx_login_password.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_login_password.Location = new Point(280, 243);
            tbx_login_password.Name = "tbx_login_password";
            tbx_login_password.Size = new Size(268, 26);
            tbx_login_password.TabIndex = 4;
            // 
            // cbx_login_Password
            // 
            cbx_login_Password.AutoSize = true;
            cbx_login_Password.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_login_Password.Location = new Point(445, 278);
            cbx_login_Password.Name = "cbx_login_Password";
            cbx_login_Password.Size = new Size(112, 18);
            cbx_login_Password.TabIndex = 5;
            cbx_login_Password.Text = "Show Password";
            cbx_login_Password.UseVisualStyleBackColor = true;
            // 
            // btn_login_signin
            // 
            btn_login_signin.BackColor = Color.FromArgb(33, 11, 97);
            btn_login_signin.Cursor = Cursors.Hand;
            btn_login_signin.FlatAppearance.BorderSize = 0;
            btn_login_signin.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btn_login_signin.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btn_login_signin.FlatStyle = FlatStyle.Flat;
            btn_login_signin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login_signin.ForeColor = Color.White;
            btn_login_signin.Location = new Point(280, 314);
            btn_login_signin.Name = "btn_login_signin";
            btn_login_signin.Size = new Size(86, 37);
            btn_login_signin.TabIndex = 6;
            btn_login_signin.Text = "SIGN IN";
            btn_login_signin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(btn_login_signin);
            Controls.Add(cbx_login_Password);
            Controls.Add(tbx_login_password);
            Controls.Add(tbx_login_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(33, 11, 97);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label3;
        private TextBox tbx_login_username;
        private Label label4;
        private TextBox tbx_login_password;
        private CheckBox cbx_login_Password;
        private Button btn_login_signin;
        private Button btn__login_signup;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
    }
}
