using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using task_manager.BLL;
using task_manager.DAL;
using task_manager.Entities;

namespace task_manager
{
    public partial class frm_Home : KryptonForm
    {
        private WorkspaceBLL workspaceBLL;
        private WorkspaceDAL workspaceDAL;

        public frm_Home()
        {
            InitializeComponent();
            workspaceBLL = new WorkspaceBLL();
            workspaceDAL = new WorkspaceDAL();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            LoadWorkspacesAsButtons(); // Tải danh sách workspace khi form được load
        }

        public void LoadWorkspacesAsButtons()
        {
            flowLayoutPanelWorkspaces.Controls.Clear(); // Xóa các button cũ

            List<WorkspaceEnti> workspaces = workspaceDAL.GetAllWorkspace(); // Lấy danh sách workspace
            foreach (var workspace in workspaces)
            {
                Button workspaceButton = new Button
                {
                    Text = workspace.Name,
                    Width = 80,
                    Height = 50,
                    Margin = new Padding(5),
                    ForeColor = Color.Black,
                    Font = new Font(Font, FontStyle.Bold)
                };

                workspaceButton.Click += (sender, e) =>
                {
                    MessageBox.Show($"Bạn đã nhấn vào workspace: {workspace.Name}");
                };

                flowLayoutPanelWorkspaces.Controls.Add(workspaceButton); // Thêm button vào FlowLayoutPanel
            }
        }

        private void btn_addWorkspace_Click(object sender, EventArgs e)
        {
            frm_Workspace frm_Workspace = new frm_Workspace();
            frm_Workspace.WorkspaceAdded += LoadWorkspacesAsButtons; // Đăng ký lắng nghe sự kiện
            frm_Workspace.ShowDialog(); // Mở form tạo workspace
        }
    }
}
