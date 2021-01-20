using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Allerigies
{
    enum Allergy
    {
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128,

    }
    class Person
    {
        public string Name;
        public int Score;

        public Person()
        {

        }
        public Person(string name, int score = 0)
        {
            Name = name;
            Score = score;
        } 


        public List<string> GetAllergies()
        {
            List<string> allergyList = new List<string>();
            int tempScore = Score;

            foreach (var allergyType in Enum.GetValues(typeof(Allergy)))
            {
                if ((tempScore & (int)allergyType) != 0)
                {
                    allergyList.Add(allergyType.ToString());
                }
            }
            return allergyList;
        }

        public void AddAllergy(string allergyType)
        {       
                int value = (int)Enum.Parse(typeof(Allergy), allergyType);
                Score += value;  
        }

        public void AddAllergy(int allergyType)
        {
            
            Score += allergyType;
        }

        public void DeleteAllergy(string allergyType)
        {
            int value = (int)Enum.Parse(typeof(Allergy), allergyType);
            Score -= value;
        }

        public void DeleteAllergy(int allergyType)
        {
            Score -= allergyType;
        }


        public List<string> List()
        {
            var allergies = this.GetAllergies();
            return allergies;
        }

        public override string ToString()
        {
            var allergies = this.List();
            string s = "";
            if (Score > 0)
            {
                s = Name + " is allergic to ";
                int loop = 1;
                foreach (var item in allergies)
                {

                    if (loop == allergies.Count())
                    {
                        s += item + ".";
                    }
                    else if(loop == allergies.Count() - 1)
                    {
                        s += item + " and ";
                    }
                    else
                    {
                        s += item + ", ";
                    }
                    loop++;

                }
            }
            else
            {
                s = Name + " has no allergies!";
            }
            return s;
        }
        public bool isAllergic(int intAllergyType)
        {
            var allergyList = this.GetAllergies();

            return allergyList.Contains(Enum.GetName(typeof(Allergy), intAllergyType));
        }

    }
}
