/*
 * Hashtable class: https://docs.microsoft.com/en-us/dotnet/api/system.collections.hashtable?view=netframework-4.8
 */ 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new hashtable
            Hashtable openWith = new Hashtable();

            // To add things key/value pairs to the table.
            // There can not be duplicate keys but there can be duplicate values.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            // openWith.Add("num", 1);

            // Add method throws and exception if the new key is already in the table
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key \"txt\" already exists.");
            }

            // Using a key to retrieve a value
            Console.WriteLine(openWith["txt"]);
           //  Console.WriteLine(openWith["num"]);

            // Using a key to set a new value
            openWith["txt"] = "winword.exe";
            Console.WriteLine(openWith["txt"]);

            // If a key doesn't exist, setting a new key will add it to the hashtable
            openWith["doc"] = "winword.exe";
            Console.WriteLine(openWith["doc"]);
            
            // ContainsKey method can be used to see if the key is already being used before inserting
            if(!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine(openWith["ht"]);
            }
            else
            {
                Console.WriteLine("The key already exists");
            }

            // To get the values alone, use the Values property
            ICollection valueColl = openWith.Values;

            Console.WriteLine();
            // Elements of ValueCollection are strongly typed
            // Will throw an error if there are different types in the table
            foreach(string s in valueColl)
            {
                Console.WriteLine($"Value = {s}");
            }

            // To get the keys allone use the Keys property
            ICollection keyColl = openWith.Keys;
            // KeyColletion is strongly typed as well
            Console.WriteLine();            
            foreach(string s in keyColl)
            {
                Console.WriteLine($"Key = {s}");
            }

            //Use the .Remove(object key) to remove a key/value pair
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");
            if(!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }

            int x = openWith.GetHashCode();
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
