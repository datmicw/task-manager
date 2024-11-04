using System;
using task_manager.Entities;
using task_manager.DAL;

namespace task_manager.BLL
{
    public class WorkspaceBLL
    {
        private readonly WorkspaceDAL workspaceDAL;
        public WorkspaceBLL()
        {
            workspaceDAL = new WorkspaceDAL();
        }
        public int AddWorkspace(WorkspaceEnti workspace)
        {
            return workspaceDAL.AddWorkspace(workspace);
        }
        private void ValidateWorkspace(WorkspaceEnti workspace)
        {
            if (string.IsNullOrWhiteSpace(workspace.Name))
                throw new ArgumentException("Name không được để trống.");
            if (string.IsNullOrWhiteSpace(workspace.Description))
                throw new ArgumentException("Description không được để trống.");

        }
    }
}
