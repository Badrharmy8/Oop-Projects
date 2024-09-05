using System;
using System.Globalization;
class Queue
{
    

    const int tasksCount = 20;
    string[] tasks = new string[tasksCount];
    string[] dateTimes = new string[tasksCount];
    string[] deletedTasks = new string[tasksCount];
    string[] deletedDateTimes = new string[tasksCount];
    int first;
    int last;
    int deletedIndex;
    int count;

    //default constructor
    public Queue()
    {
        first = last = count = 0;
        deletedIndex = 0;
    }

    //check is empty or not
    public bool isEmpty()
    {
        return count == 0;
    }

    //check is full or not
    public bool isFull()
    {
        return count == tasksCount;
    }

    //add new task
    public void addTask(string taskName, string finishedTime)
    {
        if(isFull())
        {
            Console.WriteLine("Tasks Is Full, Cannot Add New Task.");
        }
        else
        {
            tasks[last] = taskName;
            dateTimes[last] = finishedTime;
            last = (last + 1) % tasksCount;
            count++;
        }
    }

    // remove a task
    public void removeTask()
    {
        if(isEmpty())
        {
            Console.WriteLine("There Is No Task To Be Removed.");
        }
        else
        {
            string deletedTask = tasks[first];
            string deletedTime = dateTimes[first];
            first = (first + 1) % tasksCount;
            count--;
        }
    }

    // finished task
    public void finishTask()
    {
        if (isEmpty())
        {
            Console.WriteLine("There Is No Task To Be Removed.");
        }
        else
        {
            deletedTasks[deletedIndex] = tasks[first];
            deletedDateTimes[deletedIndex] = dateTimes[first];
            deletedIndex++;
            removeTask();
        }
    }

    //display completed tasks
    public void displayCompleted()
    {
        for(int i = 0; i < deletedIndex; i++)
        {
            Console.WriteLine(deletedTasks[i]);
        }
    }

    //display not completed tasks
    public void display()
    {
        for(int i = first; i < last; i = (i + 1) % tasksCount)
        {
            Console.WriteLine(tasks[i]);
        }
    }

   //search for task
   public void search(string name)
    {
        int i = first;
        while(i < last)
        {
            if (tasks[i] == name)
            {
                Console.WriteLine("The TasK Is Number  : " + ++i);
                break;
            }
            else
            {
                i++;
            }
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Queue q1 = new Queue();
        q1.addTask("courseOne","8/8/2024  8:00 PM");
        q1.addTask("excersise", "8/8/2024 7:00 PM");
        q1.addTask("reading", "8/8/2024 12:00 AM");
        q1.search("reading");
        q1.finishTask();  
        q1.finishTask();
        q1.display();
        q1.displayCompleted();
    }
}
