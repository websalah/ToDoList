namespace ToDoList
{
    public class LinkedList
    {
        public Node? Head { get; set; }

        public void AddTask(string task)
        {
            if (Head == null)
            {
                Node node = new Node();
                node.Data = task;
                node.Next = Head;
                Head = node;
            }
            else
            {
                
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                Node node = new Node();
                node.Data = task;
                current.Next = node;
            }
        }

        public Node? RemoveTask(int index)
        {
            if (Head == null)
            {
                return null;
            }
            else
            {
                Node current = Head;
                Node? previous = null;
                int count = 1;
                while (current != null)
                {
                    if (count == index)
                    {
                        if (previous == null)
                        {
                            Head = current.Next;
                        }
                        else
                        {
                            previous.Next = current.Next;
                        }
                        return current;
                    }
                    previous = current;
                    current = current.Next;
                    count++;
                }
                return null;
            }
        }
        public void ShowTasks()
        {
            Node current = Head;
            int count = 1;
            while (current != null)
            {
                Console.WriteLine($"{count}. {current.Data}");
                current = current.Next;
                count++;
            }
        }

        public Node? EditTask(int index, string text)
        {
            Node current = Head;
            int count = 1;
            while (current != null)
            {
                if(count == index)
                {
                    current.Data = text;
                    return current;
                }
                current = current.Next;
                count++;
            }

            return current;

        }
    }
}