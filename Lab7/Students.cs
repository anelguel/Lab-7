using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Student
    {
        string name;
        string hometown;
        string food;
        int number;

        public Student(string n, string h, string f, int i)
        {
            name = n;
            hometown = h;
            food = f;
            number = i;
        }

        public int getStudentNumber() //return number
        {
            return number;
        }

        public string getStudentName() //return name
        {
            return name;
        }

        public string getFood() //return food
        {
            return food;
        }

        public string getHometown() //return hometown
        {
            return hometown;
        }
    }
}

