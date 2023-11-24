#include<stdio.h>
#include<stdbool.h> //for bool

#define CAPACITY 5

int queue[CAPACITY];
int front=0, rear=-1, totalItem=0;

//check queue is full or not
bool isFull()
{
    if(totalItem==CAPACITY)
    {
        return true;
    }
    return false;
}

//check queue is Empty or not
bool isEmpty()
{
    if(totalItem==0)
    {
         return true;
    }
    return false;
}

//Insert data in queue
void enqueue(int item)
{
    if(isFull())
    {
        printf("Sorry, the queue is full.\n");
        return;
    }
    rear= (rear + 1) % CAPACITY;
    queue[rear]=item;
    totalItem++;
}

int dequeue()
{
    if(isEmpty())
    {
        printf("Sorry, the queue is empty.\n");
        return -1;
    }
    int frontItem = queue[front];
    queue[front]=0;
    front= (front+1)% CAPACITY;
    totalItem--;
    return frontItem;
}
void printQueue()
{
    int i;
    printf("Queue: ");
    for(i=0;i<CAPACITY; i++)
    {
        printf("%d ",queue[i]);
    }
    printf("\n");
}
int main()
{
    printf("Lets implement Queue in C.\n\n");
    enqueue(10);
    enqueue(20);
    enqueue(30);
    enqueue(40);
    enqueue(50);
    printQueue();
    enqueue(60);
    printf("Dequeue: %d\n", dequeue());
    printQueue();
    enqueue(60);
    printQueue();
    printf("Dequeue: %d\n", dequeue());
    printQueue();
    return 0;
}
