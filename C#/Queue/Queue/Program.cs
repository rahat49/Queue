class Program
{
    const int CAPACITY = 5;
    int[] queue= new int[CAPACITY];
    int front = 0, rear = -1, totalItem = 0;

    bool isFull()
    {
        if (totalItem == CAPACITY)
        {
            return true;
        } 
           return false;
    }
    bool isEmpty()
    {
        if (totalItem == 0)
        {
            return true;
        }
        return false;
    }

    void Enqueue(int item)
    {
        if(isFull())
        {
            Console.WriteLine("Sorry, Queue is Full.");
            return;
        }
        rear = (rear + 1) % CAPACITY;
        queue[rear] = item;
        totalItem++;
    }
    int Dequeue()
    {
        if(isEmpty())
        {
            Console.WriteLine("ueue is Empty.");
            return -1;
        }

        int frontItem = queue[front];
        queue[front] = 0;
        front= (front + 1) % CAPACITY;
        totalItem--;
        return frontItem;
    }
    void printQueue()
    {
        int i;
        Console.Write("Queue: ");
        for (i=0;i<CAPACITY;i++)
        {
            Console.Write($"{queue[i]} ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Program queue = new Program();
        Console.WriteLine("Lets Implement Queue Data Structure Using C#.\n");

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);
        queue.printQueue();
        queue.Enqueue(60);
        Console.Write($"Dequeue: {queue.Dequeue()}\n");
        queue.printQueue();
        queue.Enqueue(60);
        queue.printQueue();
    }
}