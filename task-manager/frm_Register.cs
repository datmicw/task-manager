﻿using System;
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
    public partial class frm_Register : KryptonForm
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void btn_BackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
