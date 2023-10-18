using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBobkoManager.Core.Interfaces;

namespace TaskBobkoManager.Core.Entities.Site
{
    public class Task : IEntity
    {
        public int Id { get ; set ; }
        public string TaskName { get ; set ; }=string.Empty;
        public DateTime DateDeadLine { get ; set ; }
        public string Description { get ; set ; }= string.Empty;
        public int SubTaskId { get ; set ; }
        public SubTask SubTask { get ; set ; }
    }
}
