using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using task_manager.BLL;
using task_manager.DAL;
using task_manager.Entities;
using static task_manager.frm_Login;
using static task_manager.frm_Workspace;

namespace task_manager
{
    public partial class frm_Task : KryptonForm
    {
        private readonly TaskDAL taskDAL;
        private readonly TaskBLL taskBLL;
        public int WorkspaceID { get; set; }
        public string WorkspaceName { get; set; }

        public frm_Task(int workspaceID, string workspaceName)
        {
            InitializeComponent();
            this.WorkspaceName = workspaceName;
            this.WorkspaceID = workspaceID;
            taskDAL = new TaskDAL();
            taskBLL = new TaskBLL();
        }

        private void frm_Task_Load(object sender, EventArgs e)
        {
            lb_OwnerName.Text = GlobalData.LoggedInCustomerName;
            lb_WorkspaceName.Text = WorkspaceName;
            LoadTask();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddText.Text))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            var task = new TaskEnti
            {
                CustomerId = GlobalData.LoggedInCustomerID,
                Title = txt_AddText.Text,
                WorkspaceId = this.WorkspaceID
            };

            try
            {
                taskDAL.AddTask(task);
                KryptonMessageBox.Show("Task added successfully");
                txt_AddText.Text = string.Empty;
                LoadTask();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding task: {ex.Message}");
            }
        }

        private void LoadTask()
        {
            flowLayoutPanel1.AutoScroll = true;

            flowLayoutPanel1.Controls.Clear();

            int customerId = GlobalData.LoggedInCustomerID;
            int workspaceId = this.WorkspaceID;

            List<string> taskTitles = taskDAL.GetTaskTitles(customerId, workspaceId);

            if (taskTitles.Count == 0)
            {
                Label noTaskLabel = new Label
                {
                    Text = "No tasks available.",
                    AutoSize = false,
                    Width = 346,
                    Height = 30,
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                    BackColor = Color.LightGray,
                    Font = new Font("Arial", 10, FontStyle.Regular)
                };

                flowLayoutPanel1.Controls.Add(noTaskLabel);
            }
            else
            {
                foreach (var title in taskTitles)
                {
                    Label taskLabel = new Label
                    {
                        Text = title,
                        AutoSize = false,
                        Width = 346,
                        Height = 30,
                        Margin = new Padding(5),
                        TextAlign = ContentAlignment.MiddleLeft,
                        ForeColor = Color.Black,
                        BackColor = Color.White,
                        Font = new Font("Arial", 10, FontStyle.Regular)
                    };
                    flowLayoutPanel1.Controls.Add(taskLabel);
                }

            }
        }

    }
}