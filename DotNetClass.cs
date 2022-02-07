using System;

#nullable enable
namespace ClassRegister
{

    public class DotNetClass 
    {
        List<Student> myStudents = new List<Student> ();

        // public DotNetClass(Student[] students)
        // {
        //     Students = students;
        //     ClassSize = students.Count();
        // }

        public DotNetClass() {
          Students = myStudents;
          ClassSize = myStudents.Count();
        }

        public int ClassSize { get; }
        public List<Student> Students { get; }

        public void AddStudent() {
          string firstName = "";
          string lastName;
          string ? email; 
          string ? phoneNumber;
          bool genderSelectedCorrectly = false;
          Gender gender = Gender.Other;
          List<string> gadgets = new List<string> ();
          bool gadgetAdditionFinished = false;

          while (firstName.Length < 2) {
            Console.WriteLine("Enter your first Name: ");
            firstName = Console.ReadLine();
          }

          Console.WriteLine("Enter your last Name");

         lastName = Console.ReadLine();

          while (!genderSelectedCorrectly) {
            Console.WriteLine("Please Enter your gender Male (M) / Female (F) / Other (O): ");

            switch (Console.ReadLine().ToUpper())
            {
              case "M":
                gender = Gender.Male;
                genderSelectedCorrectly = true;
                break;
              case "Male":
                gender = Gender.Male;
                genderSelectedCorrectly = true;
                break;
              case "F":
                gender = Gender.Female;
                genderSelectedCorrectly = true;
                break;
              case "Female":
                gender = Gender.Female;
                genderSelectedCorrectly = true;
                break;
              case  "O":
                gender = Gender.Other;
                genderSelectedCorrectly = true;
                break;
              case "Other":
                gender = Gender.Other;
                genderSelectedCorrectly = true;
                break;
              default:
                genderSelectedCorrectly = false;
                break;
            }
          }


          while (!gadgetAdditionFinished) {
            string newGadget ="";
            Console.WriteLine("Please enter in a name of a gadget or q to quit: ");

            newGadget = Console.ReadLine();

            if (newGadget == "q") {
              gadgetAdditionFinished = true;
            } else if (newGadget.Trim().Length > 0) {
                gadgets.Add(newGadget);
            } else {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("Please supply a valid input");
              Console.ForegroundColor = ConsoleColor.White;
            }
            
          }

        
          while(!Validate.ValidateEmail(email)) {
            Console.WriteLine("Enter your email address: ");
            email = Console.ReadLine();

            Validate.ShowErrorText("email", Validate.ValidateEmail(email));
          }

          while (!Validate.ValidatePhoneNumber(phoneNumber)) {
            Console.WriteLine("Enter Phone Number: ");
            phoneNumber = Console.ReadLine();
          }

          myStudents.Add(new Student(){
            Firstname = firstName,
            Lastname = lastName,
            Gender = gender,
            Gadgets = gadgets,
            phoneNumber = phoneNumber,
            email = email
          });
        }

        public void PrintClassDetails()
        {
            foreach (Student dev in myStudents)
            {
                Console.WriteLine(dev.ToString());
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