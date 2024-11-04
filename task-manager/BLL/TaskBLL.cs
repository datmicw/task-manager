using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager.DAL;
using task_manager.Entities;

namespace task_manager.BLL
{
    public class TaskBLL
    {
        private readonly TaskDAL taskDAL;
        public TaskBLL()
        {
            taskDAL = new TaskDAL();
        }
        public void AddTask(TaskEnti task)
        {
            ValidateTask(task);
            taskDAL.AddTask(task);
        }
        private void ValidateTask(TaskEnti task)
        {
            if (string.IsNullOrWhiteSpace(task.Title))
                throw new ArgumentException("Title không được để trống.");
         }
    }
}
