using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User();
            user1.Name = "masha";
            user1.Surname = "Kate";
            Validate(user1);
            Console.WriteLine();
            Console.ReadKey();
            
        }

        private static void Validate(User user)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
                Console.WriteLine("Пользователь прошел валидацию");
        }
    }
}
