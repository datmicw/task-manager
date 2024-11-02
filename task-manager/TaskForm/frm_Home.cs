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
    public partial class frm_Home : KryptonForm
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void frm_Task_Load(object sender, EventArgs e)
        {

        }

        private void btn_addWorkspace_Click(object sender, EventArgs e)
        {
            frm_Workspace frm_Workspace = new frm_Workspace();
            frm_Workspace.ShowDialog();
        }
    }
}
