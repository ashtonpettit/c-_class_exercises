using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SpellItOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string spellType = Console.ReadLine();
            

            StreamReader reader = File.OpenText("spells.txt");
            

            string spellBook = reader.ReadLine();
            



            
            while (spellBook != null)
            {
                spellBook = spellBook.ToLower();

                if (spellBook.Contains(spellType))
                {
                    Console.WriteLine(spellBook);
                    
                } 
                
                spellBook = reader.ReadLine();
            }

            reader.Close();  
            
             
        }
    }
}
