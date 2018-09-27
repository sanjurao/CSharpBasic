using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NotesAndCoins
    {
        public void Program()
        {
            int tetsCase = int.Parse(Console.ReadLine());

             int count = 0;
            Bag<Curr> BagCurr = new Bag<Curr>(tetsCase);
            while (count < tetsCase && tetsCase < 100)
            {
                string[] Cur = Console.ReadLine().Split(' ');
                if (Cur[0].ToLower() == "coins")
                {
                    BagCurr.Add(new Curr { type = "coins", val = int.Parse(Cur[1]) });
                }
                else if (Cur[0].ToLower() == "notes")
                {
                    BagCurr.Add(new Curr { type = "notes", val = int.Parse(Cur[1]) });                    
                }
                count++;
            }
            Console.WriteLine("Coins :");            
            BagCurr.Display("coins");
            Console.WriteLine("Notes :");
            BagCurr.Display("notes");
            Console.ReadKey();

        }
        class Curr
        {
            public string type { get; set; }
            public int val { get; set; }
        }

        class Bag<T> where T : Curr
        {
            //public int val = 10;
            T[] listval;
            public Bag(int size)
            {
                listval = new T[size];
            }
            int count = 0;

            public void Add(T item)
            {
                if (count + 1 < 100)
                {

                    listval[count] = item;
                }
                count++;
            }

            public void Display(string CurrType)
            {
                for (var i = 0; i < listval.Length; i++)
                {
                    if (listval[i].type == CurrType)
                    {
                        Console.WriteLine(listval[i].val);
                    }
                }
            }

            public T this[int index]
            {
                get { return listval[index]; }
                set { listval[index] = value; }
            }

        }
    }
}
