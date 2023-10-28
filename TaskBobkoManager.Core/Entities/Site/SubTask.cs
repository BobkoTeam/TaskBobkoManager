using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBobkoManager.Core.Interfaces;

namespace TaskBobkoManager.Core.Entities.Site
{
    public class SubTask : IEntity
    {
        public int Id { get ; set; }
        public string Name { get; set; } = string.Empty;

    }
}
