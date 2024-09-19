using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    class ToDoItem
    { 
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public ToDoItem(string name)
        {
            this.Name = name;
            IsCompleted = false;
        }
    }
}
