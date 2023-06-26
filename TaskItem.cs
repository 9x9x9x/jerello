using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jerello
{
    public class TasksItem
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Summary { get; set; }
        public string? Deadline { get; set; }
        public bool IsDone { get; set; } = false;
    }
}