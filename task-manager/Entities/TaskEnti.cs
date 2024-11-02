using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager.Entities
{
    public class TaskEnti
    {
        public int Id { get; set; }
        public int WorkspaceId { get; set; }
        public int CustomerId { get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public CustomerEnti CustomerEnti { get; set; }
        public WorkspaceEnti WorkspaceEnti { get; set; }
    }
}
