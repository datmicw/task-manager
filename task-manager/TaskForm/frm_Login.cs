using ComponentFactory.Krypton.Toolkit;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using task_manager.BLL;
using task_manager.DAL;
using task_manager.Entities;
namespace task_manager
{
    public partial class frm_Login : KryptonForm
    {
        private CustomerDAL customerDAL;
        private CustomerBLL customerBLL;
        public frm_Login()
        {
            InitializeComponent();
            customerDAL = new CustomerDAL();
            customerBLL = new CustomerBLL();
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_Register registerForm = new frm_Register();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }
        public static class GlobalData
        {
            public static int LoggedInCustomerID;
            public static string LoggedInCustomerName;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var customer = new CustomerEnti
            {
                Email = txt_Email.Text,
                Password = txt_Password.Text
            };

            try
            {
                var CheckCustomer = customerBLL.GetCustomer(customer.Email);

                if (CheckCustomer == null)
                {
                    MessageBox.Show("Email not found.");
                    return;
                }
                bool isPasswordValid = BCrypt.Net.BCrypt.Verify(customer.Password, CheckCustomer.Password);

                if (isPasswordValid)
                {
                    GlobalData.LoggedInCustomerID = CheckCustomer.Id;
                    GlobalData.LoggedInCustomerName = CheckCustomer.Name;
                    frm_Home frm_Home = new frm_Home();
                    frm_Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}
