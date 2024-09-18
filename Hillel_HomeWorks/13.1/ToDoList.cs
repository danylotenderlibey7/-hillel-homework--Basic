using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    class ToDoList
    { 
        public string name { get; set; }
        public bool IsCompleted { get; set; }
        public ToDoList(string name)
        {
            this.name = name;
            IsCompleted = false;
        }
    }
}
