using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using task_manager.BLL;
using task_manager.DAL;
using task_manager.Entities;
using static task_manager.frm_Login;
namespace task_manager
{
    public partial class frm_Workspace : KryptonForm
    {
        public event Action WorkspaceAdded;
        private WorkspaceBLL workspaceBLL;
        private WorkspaceDAL workspaceDAL;
        public frm_Workspace()
        {
            InitializeComponent();
            workspaceBLL = new WorkspaceBLL();
            workspaceDAL = new WorkspaceDAL();
        }
        public static class GloWorkspace
        {
            public static string WorkspaceName;
        }
        private void btn_create_w_Click(object sender, EventArgs e)
        {
            var workspace = new WorkspaceEnti
            {
                Name = txt_Name.Text,
                Description = txt_description.Text,
                CustomerID = GlobalData.LoggedInCustomerID,
            };
            try
            {
                workspaceBLL.AddWorkspace(workspace);
                GloWorkspace.WorkspaceName = workspace.Name;
                MessageBox.Show("Workspace added successfully");
                WorkspaceAdded?.Invoke();
                this.Close();

            } catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
    }
}
