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
            tbxRegisterPassword = new TextBox();
            tbxRegisterUserName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btn_register_signin = new Button();
            label5 = new Label();
            label1 = new Label();
            dtpRegisterBirthDate = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            tbxRegisterFirstName = new TextBox();
            tbxRegisterLastName = new TextBox();
            textbox3423 = new Label();
            tbxRegisterEmail = new TextBox();
            label9 = new Label();
            cbxRegisterGender = new ComboBox();
            textbox = new Label();
            tbxRegisterAddress = new TextBox();
            label11 = new Label();
            cbxRegisterDepartment = new ComboBox();
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
            btn_register_signup.Location = new Point(281, 504);
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
            cbx_register_Password.Cursor = Cursors.Hand;
            cbx_register_Password.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_register_Password.Location = new Point(437, 480);
            cbx_register_Password.Name = "cbx_register_Password";
            cbx_register_Password.Size = new Size(112, 18);
            cbx_register_Password.TabIndex = 14;
            cbx_register_Password.Text = "Show Password";
            cbx_register_Password.UseVisualStyleBackColor = true;
            cbx_register_Password.CheckedChanged += cbx_register_Password_CheckedChanged;
            // 
            // tbxRegisterPassword
            // 
            tbxRegisterPassword.BackColor = SystemColors.MenuBar;
            tbxRegisterPassword.Cursor = Cursors.Hand;
            tbxRegisterPassword.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRegisterPassword.Location = new Point(281, 448);
            tbxRegisterPassword.Name = "tbxRegisterPassword";
            tbxRegisterPassword.PasswordChar = '*';
            tbxRegisterPassword.Size = new Size(268, 26);
            tbxRegisterPassword.TabIndex = 12;
            // 
            // tbxRegisterUserName
            // 
            tbxRegisterUserName.BackColor = SystemColors.MenuBar;
            tbxRegisterUserName.Cursor = Cursors.Hand;
            tbxRegisterUserName.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRegisterUserName.Location = new Point(281, 400);
            tbxRegisterUserName.Name = "tbxRegisterUserName";
            tbxRegisterUserName.Size = new Size(268, 26);
            tbxRegisterUserName.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(281, 429);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 10;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 381);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 11;
            label3.Text = "UserName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(281, 9);
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
            panel1.Size = new Size(254, 550);
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
            btn_register_signin.Location = new Point(44, 506);
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
            label5.Location = new Point(60, 489);
            label5.Name = "label5";
            label5.Size = new Size(134, 14);
            label5.TabIndex = 0;
            label5.Text = "Already Have Account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(281, 144);
            label1.Name = "label1";
            label1.Size = new Size(68, 16);
            label1.TabIndex = 10;
            label1.Text = "Birth Date:";
            // 
            // dtpRegisterBirthDate
            // 
            dtpRegisterBirthDate.Cursor = Cursors.Hand;
            dtpRegisterBirthDate.Location = new Point(281, 163);
            dtpRegisterBirthDate.Name = "dtpRegisterBirthDate";
            dtpRegisterBirthDate.Size = new Size(268, 25);
            dtpRegisterBirthDate.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(281, 48);
            label7.Name = "label7";
            label7.Size = new Size(78, 16);
            label7.TabIndex = 11;
            label7.Text = "First Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(281, 96);
            label8.Name = "label8";
            label8.Size = new Size(76, 16);
            label8.TabIndex = 10;
            label8.Text = "Last Name :";
            // 
            // tbxRegisterFirstName
            // 
            tbxRegisterFirstName.BackColor = SystemColors.MenuBar;
            tbxRegisterFirstName.Cursor = Cursors.Hand;
            tbxRegisterFirstName.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRegisterFirstName.Location = new Point(281, 67);
            tbxRegisterFirstName.Name = "tbxRegisterFirstName";
            tbxRegisterFirstName.Size = new Size(268, 26);
            tbxRegisterFirstName.TabIndex = 13;
            // 
            // tbxRegisterLastName
            // 
            tbxRegisterLastName.BackColor = SystemColors.MenuBar;
            tbxRegisterLastName.Cursor = Cursors.Hand;
            tbxRegisterLastName.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRegisterLastName.Location = new Point(281, 115);
            tbxRegisterLastName.Name = "tbxRegisterLastName";
            tbxRegisterLastName.PasswordChar = '*';
            tbxRegisterLastName.Size = new Size(268, 26);
            tbxRegisterLastName.TabIndex = 12;
            // 
            // textbox3423
            // 
            textbox3423.AutoSize = true;
            textbox3423.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textbox3423.Location = new Point(281, 239);
            textbox3423.Name = "textbox3423";
            textbox3423.Size = new Size(97, 16);
            textbox3423.TabIndex = 11;
            textbox3423.Text = "Email Address :";
            // 
            // tbxRegisterEmail
            // 
            tbxRegisterEmail.BackColor = SystemColors.MenuBar;
            tbxRegisterEmail.Cursor = Cursors.Hand;
            tbxRegisterEmail.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRegisterEmail.Location = new Point(281, 258);
            tbxRegisterEmail.Name = "tbxRegisterEmail";
            tbxRegisterEmail.Size = new Size(268, 26);
            tbxRegisterEmail.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(281, 287);
            label9.Name = "label9";
            label9.Size = new Size(57, 16);
            label9.TabIndex = 11;
            label9.Text = "Gender :";
            // 
            // cbxRegisterGender
            // 
            cbxRegisterGender.BackColor = SystemColors.MenuBar;
            cbxRegisterGender.Cursor = Cursors.Hand;
            cbxRegisterGender.FormattingEnabled = true;
            cbxRegisterGender.Location = new Point(281, 306);
            cbxRegisterGender.MaxDropDownItems = 3;
            cbxRegisterGender.Name = "cbxRegisterGender";
            cbxRegisterGender.Size = new Size(268, 25);
            cbxRegisterGender.TabIndex = 17;
            // 
            // textbox
            // 
            textbox.AutoSize = true;
            textbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textbox.Location = new Point(281, 191);
            textbox.Name = "textbox";
            textbox.Size = new Size(99, 16);
            textbox.TabIndex = 11;
            textbox.Text = "Home Address :";
            // 
            // tbxRegisterAddress
            // 
            tbxRegisterAddress.BackColor = SystemColors.MenuBar;
            tbxRegisterAddress.Cursor = Cursors.Hand;
            tbxRegisterAddress.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbxRegisterAddress.Location = new Point(281, 210);
            tbxRegisterAddress.Name = "tbxRegisterAddress";
            tbxRegisterAddress.Size = new Size(268, 26);
            tbxRegisterAddress.TabIndex = 13;
            tbxRegisterAddress.WordWrap = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(281, 334);
            label11.Name = "label11";
            label11.Size = new Size(83, 16);
            label11.TabIndex = 11;
            label11.Text = "Department :";
            // 
            // cbxRegisterDepartment
            // 
            cbxRegisterDepartment.BackColor = SystemColors.MenuBar;
            cbxRegisterDepartment.Cursor = Cursors.Hand;
            cbxRegisterDepartment.FormattingEnabled = true;
            cbxRegisterDepartment.Location = new Point(281, 353);
            cbxRegisterDepartment.MaxDropDownItems = 99;
            cbxRegisterDepartment.Name = "cbxRegisterDepartment";
            cbxRegisterDepartment.Size = new Size(268, 25);
            cbxRegisterDepartment.Sorted = true;
            cbxRegisterDepartment.TabIndex = 17;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 550);
            Controls.Add(cbxRegisterDepartment);
            Controls.Add(cbxRegisterGender);
            Controls.Add(dtpRegisterBirthDate);
            Controls.Add(btn_register_signup);
            Controls.Add(cbx_register_Password);
            Controls.Add(tbxRegisterLastName);
            Controls.Add(tbxRegisterAddress);
            Controls.Add(tbxRegisterEmail);
            Controls.Add(tbxRegisterFirstName);
            Controls.Add(tbxRegisterPassword);
            Controls.Add(tbxRegisterUserName);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(textbox);
            Controls.Add(textbox3423);
            Controls.Add(label7);
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
        private TextBox tbxRegisterPassword;
        private TextBox tbxRegisterUserName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label exit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btn_register_signin;
        private Label label5;
        private Label label1;
        private DateTimePicker dtpRegisterBirthDate;
        private Label label7;
        private Label label8;
        private TextBox tbxRegisterFirstName;
        private TextBox tbxRegisterLastName;
        private Label textbox3423;
        private TextBox tbxRegisterEmail;
        private Label label9;
        private ComboBox cbxRegisterGender;
        private Label textbox;
        private TextBox tbxRegisterAddress;
        private Label label11;
        private ComboBox cbxRegisterDepartment;
    }
}