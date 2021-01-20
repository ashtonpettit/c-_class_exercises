using System;
using System.Collections.Generic;

namespace Allerigies
{
    class Program
    {
        static void Main(string[] args)
        {

           
           
            
            string[] instructions = Console.ReadLine().Split(' ');
            string name = instructions[1];
            Person newPerson = new Person();
            List<string> allergyList = new List<string>();

            if (instructions[1] == "Joe")
            {
                newPerson.Name = name;
                newPerson.Score = 65;
                allergyList.Add("Eggs");
                allergyList.Add("Pollen");
            }
            else
            {
                newPerson.Name = name;
            }
            if (instructions.Length > 2)
            {
                for (int i = 2; i < instructions.Length; i++)
                {
                    newPerson.AddAllergy(instructions[i]);
                    allergyList.Add(instructions[i]);
                }
            }
            
            

            instructions = Console.ReadLine().Split(' ');

            while (instructions[0] != "stop")
            {               
                if (instructions[0].Contains("print"))
                {
                    Console.WriteLine(newPerson.ToString());
                }
                else if (instructions[0].Contains("allergic"))
                {
                    int num = Convert.ToInt32(instructions[1]);
                    Console.WriteLine(newPerson.isAllergic(num));
                }
                else if (instructions[0].Contains("add"))
                {
                    if (!allergyList.Contains(instructions[1]))
                    {
                        allergyList.Add(instructions[1]);
                        newPerson.AddAllergy(instructions[1]);
                    }
                    
                }
                else if (instructions[0].Contains("delete"))
                {
                    if (allergyList.Contains(instructions[1]))
                    {
                        allergyList.Remove(instructions[1]);
                        newPerson.DeleteAllergy(instructions[1]);
                    }
                    
                }
                else if (instructions[0].Contains("score"))
                {
                    Console.WriteLine(newPerson.Score);
                }

                instructions = Console.ReadLine().Split(' ');
                
            } 
            
        }
    }
}
