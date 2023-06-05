using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Task task1 = new Task();
            task1.name = "Buy groceries";//شراء بقاله
            task1.PrintTask();

            Task task2 = new Task();
            task2.name = "Pay bills";//دفع فواتير 
            task2.PrintTask();

            Task task3 = new Task();
            task3.name = "Buy car";//شراء سياره
            task3.PrintTask();

            Task task4 = new Task();
            task4.name = "Go to University";//دهاب الي الجامعه
            task4.PrintTask();

            TaskManager.AddTask(task1);
            Console.WriteLine("Task found at : " + TaskManager.SearchForTask(task1));
            TaskManager.AddTask(task2);
            Console.WriteLine("Task found at : " + TaskManager.SearchForTask(task2));
            TaskManager.AddTask(task3);
            Console.WriteLine("Task found at : " + TaskManager.SearchForTask(task3));
            TaskManager.AddTask(task4);
            Console.WriteLine("Task found at : " + TaskManager.SearchForTask(task4));
         

            TaskManager.DeleteTask(task1);
            Console.WriteLine("Task found at : " + TaskManager.SearchForTask(task1));
            TaskManager.DeleteTask(task4);
            Console.WriteLine("Task found at : " + TaskManager.SearchForTask(task4));

            
        }
    }
}

            
