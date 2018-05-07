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

		public Student(string n, string h, string f)
		{
			name = n;
			hometown = h;
			food = f;
		}

		public void GetStudentName() 
		{
			Console.WriteLine(name);
		}

		public void Food()
		{
			Console.WriteLine(food);
		}

		public void Hometown()
		{
			Console.WriteLine(hometown);
		}

		public void HometownOrFood()
		{
			Console.WriteLine("What would you like to know about " + name +"? (enter 'hometown' or 'food')");
			string input = Console.ReadLine().ToLower();

			if (input == "food")
			{
				Console.WriteLine(name + "'s favorite food is " + food + ".");
			}
			else if (input == "hometown")
			{
				Console.WriteLine(name + "'s hometown is " + hometown + ".");
			}
			else
			{
				Console.WriteLine("That is not a valid entry.");
			}
		}
    }
}

