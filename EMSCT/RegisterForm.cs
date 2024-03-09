using EMSCT.DAL.Context;
using EMSCT.DATA;
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
            new AppDbContext(); 
            tbx_register_password.UseSystemPasswordChar = true;
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
            tbx_register_password.PasswordChar = cbx_register_Password.Checked ? '\0' : '*';
        }

        private void btn_register_signup_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            try
            {
                var checkEmployee = db.Employees.FirstOrDefault(x => x.UserName == tbx_register_username.Text);

                if (checkEmployee != null)
                {
                    MessageBox.Show("Bu kullanıcı adı ile bir çalışan kaydı vardır. Lütfen giriş yapmayı deneyin.");
                    return;
                }

                else if (tbx_register_password.Text.Length < 8)
                {
                    MessageBox.Show("Lütfen güvenliğiniz için en az 8 karakterli ve daha güvenli bir parola giriniz.");
                    tbx_register_password.Text = "";
                    return;
                }

                else
                {
                    employee.UserName = tbx_register_username.Text;
                    employee.Password = tbx_register_password.Text;
                    employee.CreateDate = DateTime.Now;
                    MessageBox.Show("Hesabınız başarıyla oluşturulmuştur.");
                    btn_register_signup.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Hatalı bir işlem gerçekleşti!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.Add(employee);
            db.SaveChanges();
        }
    }
}
