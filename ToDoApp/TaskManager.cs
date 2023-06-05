using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ToDoApp
{
    static class TaskManager
    {
        private static ArrayList tasks = new ArrayList();

        public static void AddTask(Task std)
        {
            tasks.Add(std);
            Console.WriteLine("\n Task added successfully");
        }

        public static void DeleteTask(Task std)
        {
            tasks.Remove(std);
                Console.WriteLine("\n Task deleted successfully" );
        }
        
        public static int SearchForTask(Task std)
        {
            return tasks.IndexOf(std);
        }

    }
}
