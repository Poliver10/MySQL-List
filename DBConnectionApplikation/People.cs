using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionApplikation
{
    internal class People
    {
        public int Id { get; set; }//Person ID
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sibling { get; set; }
        public string FunFact { get; set; }

        public int Id2 { get; set; }//Age ID
        public int Age2 { get; set; }
        public string Birthday { get; set; }

        public int Id3 { get; set; }//Sibling ID
        public string Sibling_name { get; set; }
        public int Sibling_age { get; set; }

        //Skapar en static lista för People objekt
        public static List<People> persons = new List<People>();

        public People(int id, string name, int age, string funfact, string sibling)
        {
            Id = id;
            Name = name;
            Age = age;
            FunFact = funfact;
            Sibling = sibling;
        }
        public static List<People> age = new List<People>();
        public People(int id2, int age2, string birthday)
        {
            Id2 = id2;
            Age2 = age2;
            Birthday = birthday;
        }
        public static List<People> sibling = new List<People>();
        public People(int id3, string sibling_name, int sibling_age)
        {
            Id3 = id3;
            Sibling_name = sibling_name;
            Sibling_age = sibling_age;
        }
    }
}