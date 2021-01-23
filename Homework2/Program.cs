using Homework1.MyDictionary;
using Homework2.MyCollection;
using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool TaskNum1 = false;

            if (TaskNum1)
            {
                MyCollection<int> myCollection = new();

                myCollection.Add(1);
                myCollection.Add(2);
                myCollection.Add(3);
                myCollection.Add(4);
                myCollection.Add(5);
                myCollection.Remove(4);
                myCollection.Add(6);
                myCollection.Remove(3);
                foreach (var item in myCollection)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                MyTRClass<int, PossibleRClass> myTRClass = new();

                myTRClass.item = 5;
                Console.WriteLine(myTRClass.item);
                var Rclass = myTRClass.SetR(2);
                Console.WriteLine(Rclass);

            }

            
        }
    }
}
