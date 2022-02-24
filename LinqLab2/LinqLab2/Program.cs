using System;
using System.Linq;

namespace LinqLab
{

    class Program
    {
        //just do the part "for nums"
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };


            //find the minimum
            var findMin = nums.Min();
            Console.WriteLine(findMin);

            //find the max
            var findMax = nums.Max();
            Console.WriteLine(findMax);

            //find the max value less than 10000
            var findMaxLess = nums.Where(x => x < 10000).ToArray();
            Console.WriteLine(String.Join(",", findMaxLess));

            //find all the values between 10 and 100
            var findLilValues = nums.Where(x => x >= 10 && x <= 100).ToArray();
            Console.WriteLine(String.Join(",", findLilValues));

            //find all the values between 100000 and 999999 inclusive
            var findBigValues = nums.Where(x => x >= 100000 && x <= 999999).ToArray();
            Console.WriteLine(String.Join(",", findBigValues));

            //count all the even numbers
            var countEven = nums.Count(x => x % 2 == 0);
            Console.WriteLine(countEven);



            //List<Student> students = new List<Student>();
            ////var studentList = new List<string, int>();

            //students.Add(new Student { name = "Jimmy", age = 13 });
            //Console.WriteLine(students);
            //foreach(var x in students)
            //{
            //    //Console.WriteLine(x);
            //}


        }
    }

    //public class Student
    //{
    //    public string name { get; set; }
    //    public int age { get; set; }
    //}

}