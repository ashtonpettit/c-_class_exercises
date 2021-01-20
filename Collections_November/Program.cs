using System;
using System.Collections.Generic;

namespace Collections_November
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> toDoList = new List<string>();

            toDoList.Add("1. Make a TO-DO List");
            toDoList.Add("2. Cross of 1st item on TO-DO List");
            toDoList.Add("3. Get out of PJ's");
            toDoList.Add("4. Eat Specaloos");

            foreach (var item in toDoList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("What have you completed today? (Type number of the item you have completed)");

            string input = Console.ReadLine();

            Console.WriteLine("You have these left to do");

            foreach (var item in toDoList)
            {
                if (!item.Contains(input))
                {
                    Console.WriteLine(item);
                }
            }
            
            

            Dictionary<char, string> fruits = new Dictionary<char, string>();

            fruits.Add('A', "apple");
            fruits['B'] = "bananna";
            fruits.Add('O', "orange");
            //fruits.Add('a', "avocado"); // add will give an exeption
            fruits['a'] = "avocado"; // will override apple

            foreach (var item in fruits)
            {
                Console.WriteLine(item + "\t" + item.Key + "--->" + item.Value)
            }

            Console.WriteLine(fruits.ContainsKey('a'));
            Console.WriteLine(fruits.ContainsValue("apple"));

            if (fruits.ContainsValue("orange"))
            {
                char key = ' ';
                foreach (var item in fruits)
                {
                    if (item.Value == "orange") key = item.Key;
                }
                fruits.Remove(key);
            }
            */

            Dictionary<string, List<string>> toDoList = new Dictionary<string, List<string>>();
            List<string> stringInput = new List<string>();
            Console.WriteLine("What is Your Name?");
            string input = Console.ReadLine();
            string name = input;
            string dateInput = " ";

            while (input != "Stop")
            {
                Console.WriteLine("Write To-Do List Date (dd/mm/yy)");
                dateInput = Console.ReadLine();
                input = " ";

                while (input != "stop")
                {
                    Console.WriteLine("Let's Input your To-Do List for the Date you entered (type stop when you're done)");
                    input = Console.ReadLine();
                    stringInput.Add(input);

                }
            }

            toDoList.Add(dateInput, stringInput);

            foreach (var item in toDoList)
            {
                Console.WriteLine(item + " ");
            }


        }
    }
}
