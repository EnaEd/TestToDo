using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToDo.Core.Models
{
    public class Item
    {
        public string TaskName { get; set; }
        public string TaskContent{ get; set; }
        public override string ToString()
        {
            return TaskName;
        }

    }
}
