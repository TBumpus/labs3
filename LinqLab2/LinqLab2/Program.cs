using LinqLab2;
using System;
using System.Linq;

namespace LinqLab
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
            //var test = studentList.Sum(x => x.Age);
            //Console.WriteLine(test);
            var age21AndUp = studentList.Where(x => x.Age >= 21).ToList();
            foreach (Student x in age21AndUp)
            {
                Console.WriteLine(x.Name);
            }


            //find the oldest student
            var oldestStudent = studentList.Max(x => x.Age);
            var newOldestStudent = studentList.Where(x => x.Age == oldestStudent).ToList();
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
            var newOldest = oldestUnder25.Max(x => x.Age);
            var nameOldest = studentList.Where(x => x.Age == newOldest).ToList();

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
            var vowel = studentList.Where(x => x.Name.StartsWith("A") || x.Name.StartsWith("E") || x.Name.StartsWith("I") || x.Name.StartsWith("O") || x.Name.StartsWith("U")).ToList();
            foreach (Student x in vowel) 
            {
                Console.WriteLine(x.Name);
            }


        }
    }



}