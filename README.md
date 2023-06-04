# my_projrct
my project about ToDoApp
 class Task
    {
        public string name
        { get; set; }
        public void PrintTask()
        {
            Console.WriteLine("Name of the task New : " + name);
        }

    }
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
