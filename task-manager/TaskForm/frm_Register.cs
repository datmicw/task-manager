using System;
using task_manager.BLL;
using task_manager.DAL;
using task_manager.Entities;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using BCrypt.Net;

namespace task_manager
{
    public partial class frm_Register : KryptonForm
    {
        private CustomerDAL customerDAL;
        private CustomerBLL customerBLL;
        public frm_Register()
        {
            InitializeComponent();
            customerDAL = new CustomerDAL();
            customerBLL = new CustomerBLL();
        }

        private void btn_BackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearField()
        {
            txt_Name.Clear();
            txt_Email.Clear();
            txt_Password.Clear();
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(txt_Password.Text);

            var customer = new CustomerEnti
            {
                Name = txt_Name.Text,
                Email = txt_Email.Text,
                Password = hashedPassword,
            };
            try
            {
                customerBLL.AddCustomer(customer);
                MessageBox.Show("Account register Successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            
        }
    }
}
