using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class CustomExceptionEx
    {
         void Main()
        {
            try
            {
                Console.WriteLine("Enter User Name:");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                string password = Console.ReadLine();

                validateCredentials(userName, password);
            }
            catch(InvalidCredentialsException ex)
            {
                Console.WriteLine("User name and password should be same {0}", ex.Message);
            }
            Console.Read();
        }

        static void validateCredentials(string userName, string password)
        {
                if (userName == password)
                    Console.WriteLine("Valid Credentials");
                else
                    throw new InvalidCredentialsException("--User name and password doesnt match--");
        }
    }
    /// <summary>
    /// My Custom Exception for validating credentials
    /// </summary>
    class InvalidCredentialsException : Exception 
    {
        public InvalidCredentialsException() : base() { }

        /// <summary>
        /// Constructor to accept the message
        /// </summary>
        /// <param name="message"> pass string value</param>
        public InvalidCredentialsException(string message) : base(message) { }


    }

}
