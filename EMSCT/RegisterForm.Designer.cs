namespace EMSCT.UI
{
    partial class RegisterForm
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
            btn_register_signup = new Button();
            cbx_register_Password = new CheckBox();
            tbx_register_password = new TextBox();
            tbx_register_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btn_register_signin = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_register_signup
            // 
            btn_register_signup.BackColor = Color.FromArgb(33, 11, 97);
            btn_register_signup.Cursor = Cursors.Hand;
            btn_register_signup.FlatAppearance.BorderSize = 0;
            btn_register_signup.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            btn_register_signup.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            btn_register_signup.FlatStyle = FlatStyle.Flat;
            btn_register_signup.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register_signup.ForeColor = Color.White;
            btn_register_signup.Location = new Point(281, 314);
            btn_register_signup.Name = "btn_register_signup";
            btn_register_signup.Size = new Size(86, 37);
            btn_register_signup.TabIndex = 15;
            btn_register_signup.Text = "SIGN UP";
            btn_register_signup.UseVisualStyleBackColor = false;
            btn_register_signup.Click += btn_register_signup_Click;
            // 
            // cbx_register_Password
            // 
            cbx_register_Password.AutoSize = true;
            cbx_register_Password.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_register_Password.Location = new Point(446, 278);
            cbx_register_Password.Name = "cbx_register_Password";
            cbx_register_Password.Size = new Size(112, 18);
            cbx_register_Password.TabIndex = 14;
            cbx_register_Password.Text = "Show Password";
            cbx_register_Password.UseVisualStyleBackColor = true;
            cbx_register_Password.CheckedChanged += cbx_register_Password_CheckedChanged;
            // 
            // tbx_register_password
            // 
            tbx_register_password.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_register_password.Location = new Point(281, 243);
            tbx_register_password.Name = "tbx_register_password";
            tbx_register_password.PasswordChar = '*';
            tbx_register_password.Size = new Size(268, 26);
            tbx_register_password.TabIndex = 12;
            // 
            // tbx_register_username
            // 
            tbx_register_username.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_register_username.Location = new Point(281, 171);
            tbx_register_username.Name = "tbx_register_username";
            tbx_register_username.Size = new Size(268, 26);
            tbx_register_username.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(281, 224);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 10;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 152);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 11;
            label3.Text = "UserName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(281, 87);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 9;
            label2.Text = "Register";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exit.Location = new Point(557, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 8;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_register_signin);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 400);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Employment_PNG_Clipart;
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
            // btn_register_signin
            // 
            btn_register_signin.BackColor = Color.FromArgb(33, 11, 97);
            btn_register_signin.Cursor = Cursors.Hand;
            btn_register_signin.FlatAppearance.BorderSize = 0;
            btn_register_signin.FlatAppearance.MouseDownBackColor = Color.Purple;
            btn_register_signin.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_register_signin.FlatStyle = FlatStyle.Flat;
            btn_register_signin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register_signin.ForeColor = Color.White;
            btn_register_signin.Location = new Point(33, 353);
            btn_register_signin.Name = "btn_register_signin";
            btn_register_signin.Size = new Size(169, 34);
            btn_register_signin.TabIndex = 1;
            btn_register_signin.Text = "LOGIN";
            btn_register_signin.UseVisualStyleBackColor = false;
            btn_register_signin.Click += btn_register_signin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(49, 336);
            label5.Name = "label5";
            label5.Size = new Size(134, 14);
            label5.TabIndex = 0;
            label5.Text = "Already Have Account?";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(btn_register_signup);
            Controls.Add(cbx_register_Password);
            Controls.Add(tbx_register_password);
            Controls.Add(tbx_register_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_register_signup;
        private CheckBox cbx_register_Password;
        private TextBox tbx_register_password;
        private TextBox tbx_register_username;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label exit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btn_register_signin;
        private Label label5;
    }
}