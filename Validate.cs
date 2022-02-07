using System;
using System.Text.RegularExpressions;  

namespace ClassRegister
{
   static class Validate {
        public static bool ValidateEmail (string email) {
          Regex regex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
          return regex.IsMatch(email);
       }

       public static bool ValidatePhoneNumber(string phoneNumber) {
          Regex regex = new Regex(@"^([0]{1})([7-9]{1})([0|1]{1})([\d]{8})$");
          return regex.IsMatch(phoneNumber);
       }

       public static void ShowErrorText(string textType, bool condition) {
           if (!condition) {
               Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nPlease supply a valid {textType}");
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