using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
	/*Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.
	 * The application will:
	 * 1. Provide information about students in a class.
	 * 2. Prompt the user to ask about a particular student.
	 * 3. Give proper responces according to user-submitted information.
	 * 4. Ask the user if he/she would like to learn about another student.
	 * Build specifications:
	 * 1. Account for invalid user input with exceptions.
	 * 2. Try to incorporate IndexOutOfRange and FormatException
	 */
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> studentData = new List<Student>();

			studentData.Add(new Student("Molly", "Rockford", "Noodles"));
			studentData.Add(new Student("Michelle", "Equador", "Spaghetti"));
			studentData.Add(new Student("Rebecca", "Charlevoix", "Pizza"));
			studentData.Add(new Student("Brianna", "Fairfield", "Gumbo"));
			studentData.Add(new Student("Tammy", "Grand Rapids", "Sushi"));
			studentData.Add(new Student("Lauren", "Plainwell", "Cheeseburgers"));
			studentData.Add(new Student("Karina", "Holland", "Tacos"));
			studentData.Add(new Student("Tommy", "Raleigh", "Indian Red Curries"));
			studentData.Add(new Student("Lisa", "Los Angeles", "Mushroom Masala Dosa"));
			studentData.Add(new Student("Jonaca", "Lansing", "Sushi"));
			studentData.Add(new Student("Tanvi", "India", "Chicken Biryani"));
			studentData.Add(new Student("Anel", "Grand Rapids", "Pizza"));

			bool loopAgain = true;
			while (loopAgain == true)
			{
				try
				{
					Console.WriteLine("Welcome to our DEVELOP(her) class.\nWhich student would you like to learn more about? (enter a number 1-12):");
					int input = Int32.Parse(Console.ReadLine());
					Console.WriteLine("Student " + input + " is: ");

					studentData[input - 1].GetStudentName();
					studentData[input - 1].HometownOrFood();
				}
				catch (FormatException)
				{
					Console.WriteLine("Sorry, that is invalid. Please try again.");
					loopAgain = true;
				}

				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("That student does not exist");
					loopAgain = true;
				}
				loopAgain = DoAgain();
			}
		}
		public static bool DoAgain()
		{
			string goAgain;
			Console.WriteLine("Would you like to learn about another student?(Y or N)");
			goAgain = Console.ReadLine();
			goAgain = goAgain.ToLower();
			bool repeat;
			if (goAgain == "y")
			{
				repeat = true;
			}
			else if (goAgain == "n")
			{
				repeat = false;
			}
			else
			{
				Console.WriteLine("Sorry not an accurate input");
				repeat = DoAgain();
			}
			return repeat;
		}
	}
}








