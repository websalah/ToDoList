using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome, This your To Do List Menu: ");
            Console.WriteLine("1. Add a task\n2. Remove a task\n3. Show tasks list\n4. Edit a task\n5. Exit");
            LinkedList list = new LinkedList();
            while (true)
            {
                
                Console.Write("Enter your choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 5)
                    {
                        break;
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter a task: ");
                            string task = Console.ReadLine();
                            list.AddTask(task);
                            break;
                        case 2:
                            Console.Write("Enter a task number: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            list.RemoveTask(index);
                            break;
                        case 3:
                            list.ShowTasks();
                            break;
                        case 4:
                            Console.Write("Enter a task number: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter new text: ");
                            string text = Console.ReadLine();
                            list.EditTask(num, text);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
