using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string []names = {"Ralph" , "Alice" , "Sam"};
            int []ids = { 1001, 1002, 1003 };
            int[] scores = { 45, 55, 65 };
            double total = 0.0;
            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            double averageScore = total / scores.Length;
            Student student = new Student(averageScore);
            for (int i = 0; i < scores.Length; i++)
            {
                student.Name = names[i];
                student.ID = ids[i];
                student.Score = scores[i];
                Console.WriteLine("Name:" + student.Name);
                Console.WriteLine("Standing:" + Math.Round(student.getStanding()));
                Console.WriteLine(" ");
            }
        }
    }
}
