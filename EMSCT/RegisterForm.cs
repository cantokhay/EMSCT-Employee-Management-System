using EMSCT.DAL.Context;
using EMSCT.DATA.Entities.Concrete;
using EMSCT.DATA.Enums;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EMSCT.UI
{
    public partial class RegisterForm : Form
    {
        AppDbContext db;

        public RegisterForm()
        {
            InitializeComponent();
        }
        
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            tbxRegisterPassword.UseSystemPasswordChar = true;

            cbxRegisterGender.DataSource = Enum.GetValues(typeof(Gender));

            List<Department> departments = new List<Department>();
            cbxRegisterDepartment.DataSource = departments;
            cbxRegisterDepartment.DisplayMember = "Name";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_signin_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void cbx_register_Password_CheckedChanged(object sender, EventArgs e)
        {
            tbxRegisterPassword.PasswordChar = cbx_register_Password.Checked ? '\0' : '*';
        }

        private void btn_register_signup_Click(object sender, EventArgs e)
        {
            AppUser employee = new AppUser();

            try
            {
                var checkEmployee = db.Employees.FirstOrDefault(x => x.UserName == tbxRegisterUserName.Text);

                if (checkEmployee != null)
                {
                    MessageBox.Show("This username has been registered. Please try login", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (tbxRegisterUserName.Text.Length <= 5)
                {
                    MessageBox.Show("Please give at least 5 characters for username", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxRegisterUserName.Text = "";
                    return;
                }

                else if (tbxRegisterPassword.Text.Length < 8)
                {
                    MessageBox.Show("Please give at least 8 characters for security", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxRegisterPassword.Text = "";
                    return;
                }

                else if (tbxRegisterFirstName.Text == null)
                {
                    MessageBox.Show("Please enter a valid name", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxRegisterFirstName.Text = "";
                    return;
                }

                else if (tbxRegisterLastName.Text == null)
                {
                    MessageBox.Show("Please enter a valid surname", "Surname Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxRegisterLastName.Text = "";
                    return;
                }

                else if (!tbxRegisterEmail.Text.Contains("@", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Please enter a valid mail address", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxRegisterEmail.Text = "";
                    return;
                }

                else if (dtpRegisterBirthDate.Value.Year - DateTime.Now.Year >= 18)
                {
                    MessageBox.Show("Employee should be at least 18 years old", "Age Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpRegisterBirthDate.Value = DateTime.Now;
                    return;
                }

                else if (cbxRegisterGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select any", "Gender Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxRegisterDepartment.SelectedIndex = -1;
                    return;
                }

                else if (cbxRegisterDepartment.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select any", "Department Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxRegisterDepartment.SelectedIndex = -1;
                    return;
                }

                else
                {
                    employee.UserName = tbxRegisterUserName.Text;
                    employee.Password = tbxRegisterPassword.Text;
                    employee.Name = tbxRegisterFirstName.Text;
                    employee.LastName = tbxRegisterLastName.Text;
                    employee.Email = tbxRegisterEmail.Text;
                    employee.BirthDate = dtpRegisterBirthDate.Value;
                    if (Enum.TryParse(cbxRegisterGender.SelectedItem.ToString(), out Gender selectedGender))
                    {
                        employee.Gender = selectedGender;
                    }
                    if (cbxRegisterDepartment.SelectedItem is Department selectedDepartment)
                    {
                        employee.Department = selectedDepartment;
                    }
                    employee.CreateDate = DateTime.Now;
                    MessageBox.Show("Account created succesfully");
                    btn_register_signup.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "There is an unknown error!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.Add(employee);
            db.SaveChanges();
        }
    }
}
