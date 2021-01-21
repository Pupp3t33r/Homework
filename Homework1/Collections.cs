using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public class Collections
    {
        public ArrayList ArrList { get; set; }

        public Hashtable HT { get; set; }

        public Queue Q { get; set; }

        public Stack St { get; set; }

        public Collections()
        {
            ArrList = new() { "Re-animator", "Nightmare on Elm Street", "Friday the 13th" };

            HT = new() { { 1985, "Re-animator" }, { 1984, "Nightmare on Elm Street" }, { 1980, "Friday the 13th"} };

            Q = new();

            foreach (var item in ArrList)
            {
                Q.Enqueue(item);
            }

            St = new();

            foreach (var item in ArrList)
            {
                St.Push(item);
            }
        }


    }
}
