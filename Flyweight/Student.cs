using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        private double averageScore;
        public Student(double a)
        {
            averageScore = a;
        }
        public double getStanding()
        {
            return ((double)score / averageScore - 1.0) * 100.0;
        }
    }
}
