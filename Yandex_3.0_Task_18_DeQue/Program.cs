﻿/*
Научитесь пользоваться стандартной структурой данных deque для целых чисел.  
Напишите программу, содержащую описание дека и моделирующую работу дека, 
реализовав все указанные здесь методы. 
Программа считывает последовательность команд и в зависимости от команды выполняет 
ту или иную операцию. После выполнения каждой команды программа должна вывести одну строчку.

Возможные команды для программы:
push_front n
Добавить (положить) в начало дека новый элемент. Программа должна вывести ok.

push_back n
Добавить (положить) в конец дека новый элемент. Программа должна вывести ok.

pop_front
Извлечь из дека первый элемент. Программа должна вывести его значение.

pop_back
Извлечь из дека последний элемент. Программа должна вывести его значение.

front
Узнать значение первого элемента (не удаляя его). Программа должна вывести его значение.

back
Узнать значение последнего элемента (не удаляя его). Программа должна вывести его значение.

size
Вывести количество элементов в деке.

clear
Очистить дек (удалить из него все элементы) и вывести ok.

exit
Программа должна вывести bye и завершить работу.

Гарантируется, что количество элементов в деке в любой момент не превосходит 100. 
Перед исполнением операций pop_front, pop_back, front, back программа должна проверять, 
содержится ли в деке хотя бы один элемент. 
Если во входных данных встречается операция pop_front, pop_back, front, back, 
и при этом дек пуст, то программа должна вместо числового значения вывести строку error.

Формат ввода
Вводятся команды управления деком, по одной на строке.

Формат вывода
Требуется вывести протокол работы дека, по одному сообщению на строке

*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{

    static void Main()
    {
        List<int> myDeQue = new List<int>();
        string com = string.Empty;
        int n = 0;
        int i = 1;

        while (i > 0)
        {
            string[] command = Console.ReadLine()!.Split(' ');
            int len = command.Length;

            if (len == 1)
            {
                com = command[0];
                if (com.Equals("push_front") || com.Equals("push_back"))
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                com = command[0];
                n = Convert.ToInt32(command[1]);
            }

            if (com.Equals("push_front"))
            {
                myDeQue.Insert(0, n);
                Console.WriteLine("ok");
            }
            if (com.Equals("push_back"))
            {
                myDeQue.Add(n);
                Console.WriteLine("ok");
            }
            if (com.Equals("pop_front"))
            {
                if (myDeQue.Count > 0)
                {
                    Console.WriteLine(myDeQue[0]);
                    myDeQue.RemoveAt(0);
                }
                else Console.WriteLine("error");
            }
            if (com.Equals("pop_back"))
            {
                if (myDeQue.Count > 0)
                {
                    Console.WriteLine(myDeQue[myDeQue.Count - 1]);
                    myDeQue.RemoveAt(myDeQue.Count - 1);
                }
                else Console.WriteLine("error");
            }

            if (com.Equals("front"))
            {
                if (myDeQue.Count > 0)
                {
                    Console.WriteLine(myDeQue[0]);
                }
                else Console.WriteLine("error");
            }
            if (com.Equals("back"))
            {
                if (myDeQue.Count > 0)
                {
                    Console.WriteLine(myDeQue[myDeQue.Count - 1]);
                }
                else Console.WriteLine("error");
            }

            if (com.Equals("size"))
            {
                Console.WriteLine(myDeQue.Count);
            }
            if (com.Equals("clear"))
            {
                myDeQue.Clear();
                Console.WriteLine("ok");
            }
            if (com.Equals("exit"))
            {
                Console.WriteLine("bye");
                i = 0;
            }
        }
    }
}