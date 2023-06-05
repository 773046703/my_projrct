using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Task
    {
        public string name
        { get; set; }
        public void PrintTask()
        {
            Console.WriteLine("Name of the task New : " + name);
        }

    }
}
