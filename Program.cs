using System;

namespace ClassRegister
{
    class Program
    {    

        static void Main()
        {
            Program.Start();
        }

        static void Start() {
            bool endProcess = false;
            string ? input = "";
            DotNetClass netClass = new DotNetClass();

            while (!endProcess) {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter A to add a new Student\nV to view all Students\nq to exit the program: ");
                

                input = Console.ReadLine();
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                
                switch(input.Trim().ToUpper()) {
                    case "A": 
                        netClass.AddStudent();
                        break;
                    case "V":
                        netClass.PrintClassDetails();
                        break;
                    case "Q":
                        endProcess = true;
                        Console.Clear();
                        break;
                    default: 
                        Console.WriteLine("Please use a valid command: ");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
            }



        }
    }

}

//class object
//field representing total number of students
//field representing the list of students in the class
//method to set the number of students
//method to add students to the class
//method to remove student from class
//class name
//class description


//student object
//student name
//student gender
//student gadgets
//student id