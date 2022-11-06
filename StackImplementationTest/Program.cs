// See https://aka.ms/new-console-template for more information

using System.Net.Mail;
using System.Net.Sockets;
using StackImplementation;
using PeopleClass;
using QueueImplementation;

StackClass<int> list1 = new StackClass<int>();
list1.Push(1);
list1.Push(2);
list1.Push(3);
list1.Peek();
list1.Pop();

People per1 = new People("Ana", "Brown");

Console.WriteLine();

StackClass<People> list2 = new StackClass<People>();
list2.Push(new People("Ana", "Brown"));
list2.Push(new People("John", "Brown"));
list2.Push(new People("Jake", "Brown"));

list2.Peek();

Queue.QueueClass<int> list3 = new Queue.QueueClass<int>();

list3.Push(1);
list3.Push(2);
list3.Push(3);
list3.Peek();
list1.Pop();