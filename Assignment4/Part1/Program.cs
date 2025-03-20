// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

//泛型链表
public class LinkedList<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;

    public void Add(T data)
    {
        if (head == null)
        {
            head = new Node(data);
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(data);
        }
    }

    public void ForEach(Action<T> action)
    {
        Node current = head;
        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}

public class Program
{
    public static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();
        //加入链表
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        // 打印链表元素
        Console.WriteLine("链表元素：");
        list.ForEach(x => Console.Write(x + " "));
        Console.WriteLine();

        // 求最大值
        int max = int.MinValue;
        list.ForEach(x => max = x > max ? x : max);
        Console.WriteLine("最大值： " + max);

        // 求最小值
        int min = int.MaxValue;
        list.ForEach(x => min = x < min ? x : min);
        Console.WriteLine("最小值： " + min);

        // 求和
        int sum = 0;
        list.ForEach(x => sum += x);
        Console.WriteLine("求和： " + sum);
    }
}