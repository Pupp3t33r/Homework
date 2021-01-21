using Homework1.MyDictionary;
using System;
using System.Collections.Generic;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            Collections coll = new();
            var newElement = new DateTime(2021, 10, 31);


            RunStuff[] run = { RunStuff.LinkedList };

            foreach (var item in run)
            {
                switch (item)
                {
                    case RunStuff.ArrList:
                        #region ArrList
                        coll.ArrList.Add(newElement);

                        Console.WriteLine("Array List:");
                        foreach (var itm in coll.ArrList)
                        {
                            Console.WriteLine(itm);
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        #endregion
                        break;
                    case RunStuff.HashTable:
                        #region Hashtable
                        coll.HT.Add(1978, newElement);
                        Console.WriteLine("HashTable:");
                        foreach (var itm in coll.HT.Keys)
                        {
                            Console.WriteLine($"{coll.HT[itm]}({itm})");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        #endregion
                        break;
                    case RunStuff.Queue:
                        #region Queue
                        coll.Q.Enqueue(newElement);
                        Console.WriteLine("Queue:");
                        var count = coll.Q.Count;
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(coll.Q.Dequeue());
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        #endregion
                        break;
                    case RunStuff.Stack:
                        #region Stack
                        coll.St.Push(newElement);
                        Console.WriteLine("Stack:");
                        var counter = coll.St.Count;
                        for (int i = 0; i < counter; i++)
                        {
                            Console.WriteLine(coll.St.Pop());
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        #endregion
                        break;
                    case RunStuff.DictionaryInterface:
                        var Key1 = new MyKey("Re-Animator", 104);
                        var Key2 = new MyOtherKey() { Name = "Hellraiser", Runtime = 94 };
                        var Value1 = new MyValue(1985);
                        var Value2 = new MyOtherValue(new DateTime(1987, 9, 18));

                        Dictionary<IKey, IValue> Dictionary = new()
                        {
                            { Key1,  Value1},
                            { Key2,  Value2}
                        };
                        foreach (var key in Dictionary.Keys)
                        {
                            Console.WriteLine($"{key} : {Dictionary.GetValueOrDefault(key)}");
                        }
                        break;
                    case RunStuff.LinkedList:
                        LinkedList<string> LL = new();
                        LL.AddLast("A Nightmare on Elm Street");
                        LL.AddLast("A Nightmare on Elm Street 2: Freddy's Revenge");
                        LL.AddLast("A Nightmare on Elm Street 3: Dream Warriors");
                        LL.AddLast("A Nightmare on Elm Street 4: The Dream Master");
                        LL.AddLast("A Nightmare on Elm Street 5: The Dream Child");
                        LL.AddLast("Freddy's Dead: The Final Nightmare");
                        LL.AddLast("Wes Craven's New Nightmare");
                        LL.AddLast("Freddy vs. Jason");
                        LL.AddLast("A Nightmare on Elm Street(2010)");
                        var toDelete = LL.Find("Freddy's Dead: The Final Nightmare");
                        LL.Remove(toDelete);
                        
                        foreach (var fred in LL)
                        {
                            Console.WriteLine(fred);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }


        }

        enum RunStuff
        {
            ArrList,
            HashTable,
            Queue,
            Stack,
            DictionaryInterface,
            LinkedList
        }

    }
}
