using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                List<Student> studentData = new List<Student>();

                Student a = new Student("Molly", "Rockford", "Noodles", 1);
                Student b = new Student("Michelle", "Equador", "Spaghetti", 2);
                Student c = new Student("Rebecca", "Charlevoix", "Pizza", 3);
                Student d = new Student("Brianna", "Fairfield", "Gumbo", 4);
                Student e = new Student("Tammy", "Grand Rapids", "Sushi", 5);
                Student f = new Student("Lauren", "Plainwell", "Cheeseburgers", 6);
                Student g = new Student("Karina", "Holland", "Tacos", 7);
                Student h = new Student("Tommy", "Raleigh", "Indian Red Curries", 8);
                Student i = new Student("Lisa", "Los Angeles", "Mushroom Masala Dosa", 9);
                Student j = new Student("Jonaca", "Lansing", "Sushi", 10);

                studentData.Add(a);
                studentData.Add(b);
                studentData.Add(c);
                studentData.Add(d);
                studentData.Add(e);
                studentData.Add(f);
                studentData.Add(g);
                studentData.Add(h);
                studentData.Add(i);
                studentData.Add(j);



                //prompt the user to ask about a particular student
                Console.WriteLine("Welcome to our DEVELOP(her) class. \n Which student would you like to learn more about? (enter a number 1-10)");
                int userNoInput = Int32.Parse(Console.ReadLine());
                foreach (Student s in studentData)
                {
                    int accessNumber = s.getStudentNumber();

                    if (accessNumber == userNoInput)
                    {
                        string outputName = s.getStudentName();
                        Console.WriteLine("Student " + accessNumber + " is " + outputName + ". What would you like to know about this student? (enter 'hometown' or 'food'):");
                        string userFoodOrHome = Console.ReadLine();
                        foreach (Student t in studentData)
                        {
                            string accessFood = s.getFood();
                            string accessHometown = s.getHometown();


                            if (userFoodOrHome == "food")
                            {
                                Console.WriteLine(outputName + "'s favorite food is " + accessFood + ". Would you like to know more? (y/n)");
                                string yesNo = Console.ReadLine();
                                if (yesNo == "y")
                                {
                                    Console.WriteLine(outputName + " is also from " + accessHometown);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Great. Have a nice day.");
                                    break;
                                }

                            }
                            else if (userFoodOrHome == "hometown")
                            {
                                Console.WriteLine(outputName + " is from " + accessHometown + ". Would you like to know more? (y/n)");
                                string yesNo = Console.ReadLine();
                                if (yesNo == "y")
                                {
                                    Console.WriteLine(outputName + "'s favorite food is also " + accessFood);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Okay. Have a nice day.");
                                    break;
                                }
                            }
                        }
                    }
                }
            
            }

        }
        public static bool Continue()
        {
            Console.WriteLine("do you want to learn more about other classmates? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand, please try again");
                goOn = Continue();
            }
            return goOn;
        }
    }
}

 
