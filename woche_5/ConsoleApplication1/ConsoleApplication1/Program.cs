using System;
using System.Collections;
using System.Collections.Generic;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //useArrays();
            useArrayList();
            useGenericList();
            useHashTable();


            Console.ReadLine();
        }



        static void useArrays()
        {
            int[] Arrayname2 = { 5, 7, 9, 3 };
           // Arrayname2 = Arrayname2 + 4;
            Console.WriteLine(Arrayname2.Length);

        }



        static void useArrayList()
        {
            
            ArrayList Liste = new ArrayList();

            Liste.Add(3);
            Liste.Add("steinam");
            Liste.Add(4.6);
            Liste.Insert(1, "test");

            foreach (object element in Liste)
            {
                Console.WriteLine(element.ToString());

            }

            //Liste.RemoveAt(1);


        }

        static void useGenericList()
        {
            

            

            List<int> intListe = new List<int>();

            intListe.Add(5);
            intListe.Add(6);


            foreach (int element in intListe)
            {
                Console.WriteLine(element.ToString());


            }

            // intListe.Add(5.5);


        }


        static void useHashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "One");
            ht.Add("Zwei", "Two");
            ht.Add("Drei", "Three");


            foreach (DictionaryEntry de in ht)
            {
                string Key = (string)de.Key; //Casting
                string value = de.Value.ToString(); //Casting
                Console.WriteLine(Key + " " + value);
            }
        }

        static void useDictionary()
        {

            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "One");
            dt.Add(2, "Two");
            dt.Add(3, "Three");
            foreach (KeyValuePair<int, String> kv in dt)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

        }


    }
}
