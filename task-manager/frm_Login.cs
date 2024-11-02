using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace task_manager
{
    public partial class frm_Login : KryptonForm
    {
        public frm_Login()
        {
            InitializeComponent();
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
    }
}
