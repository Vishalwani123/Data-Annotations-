using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Annotation
{
    internal class Basics
    {
        public void Basic()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the User Data : ");

            Console.WriteLine();

            Console.WriteLine("Enter the Name of user : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Age of user : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the department of user : ");
            string department = Console.ReadLine();

            Console.WriteLine("Enter the Email of user : ");
            string email = Console.ReadLine();

            var user = new Users
            {
                Name = name,
                Age = age,
                Department = department,
                Email = email,
            };

            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, context, results, true);

            if (isValid)
            {
                Console.WriteLine();
                Console.WriteLine("User Data is Valid.");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("User Data is Invalid.");
                Console.WriteLine();
                Console.WriteLine(context);
                Console.WriteLine();

                foreach (var validationResult in results)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }

            }
        }
    }
}
