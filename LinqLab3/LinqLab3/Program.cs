using LinqLab3;
using System;
using System.Linq;

namespace LinqLab3
{

    class Program
    {
        //just do the part "for nums"
        static void Main(string[] args)
        {




            List<Student> studentList = new List<Student>()
            {
                new Student(){ Name = "Jimmy", Age = 13},
                new Student(){ Name = "Hannah", Age = 21},
                new Student(){ Name = "Justin", Age = 30},
                new Student(){ Name = "Sarah", Age = 53},
                new Student(){ Name = "Hannibal", Age = 15},
                new Student(){ Name = "Phillip", Age = 16},
                new Student(){ Name = "Maria", Age = 63},
                new Student(){ Name = "Abe", Age = 33},
                new Student(){ Name = "Curtis", Age = 10}

            };


            //Find all students age of 21 and over
           
            var age21AndUp = studentList.Where(x => x.Age >= 21).ToList(); //firstordefault works to get the first while tolist does multiple then do a age21AndUp.Name
            foreach (Student x in age21AndUp)
            {
                Console.WriteLine(x.Name);
            }


            //find the oldest student
            //var oldestStudent = studentList.Max(x => x.Age);
            var newOldestStudent = studentList.Where(x => x.Age == studentList.Max(x => x.Age)).ToList();// OrderBy() then selecting the first would also take the top age
            foreach (Student x in newOldestStudent)
            {
                Console.WriteLine(x.Name);
            }

            //find the youngest student
            var youngestStudent = studentList.Min(x => x.Age);
            var newYoungestStudent = studentList.Where(x => x.Age == youngestStudent).ToList();
            foreach (Student x in newYoungestStudent)
            {
                Console.WriteLine(x.Name);
            }


            //Find the oldest student under age 25
            var oldestUnder25 = studentList.Where(x => x.Age < 25).ToList();
            //var newOldest = oldestUnder25.Max(x => x.Age);
            var nameOldest = studentList.Where(x => x.Age == oldestUnder25.Max(x => x.Age)).ToList();

            foreach (Student x in nameOldest)
            {
                Console.WriteLine(x.Name);
            }

            //find all students over 21 and with even ages
            var over21Even = studentList.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            foreach (Student x in over21Even)
            {
                Console.WriteLine(x.Name);
            }

            //find all teenage students 13 -19 inclusive
            var teenagers = studentList.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            foreach (Student x in teenagers)
            {
                Console.WriteLine(x.Name);
            }
            //Find all students whose name starts with a vowel

            //x.Name[0] means to take the first letter of the name
            var vowel = studentList.Where(x => x.Name.ToLower().StartsWith("a") || x.Name.ToLower().StartsWith("e") || x.Name.ToLower().StartsWith("i") || x.Name.ToLower().StartsWith("o") || x.Name.ToLower().StartsWith("u")).ToList();
            foreach (Student x in vowel)
            {
                Console.WriteLine(x.Name);
            }


        }
    }



}