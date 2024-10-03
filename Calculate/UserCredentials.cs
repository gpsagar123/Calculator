using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; } = "HardcodedPassword123"; // Hardcoded password - vulnerability

        public void DisplayCredentials()
        {
            Console.WriteLine($"Username: {Username}, Password: {Password}");
        }
    }

    public class StringConcatenator
    {
        public string ConcatenateStrings()
        {
            string result = "";
            for (int i = 0; i < 1000; i++)
            {
                result += "Iteration " + i + "; ";
            }
            return result;
        }
    }

    public class UserInputHandler
    {
        public void HandleInput(string userInput)
        {
            Console.WriteLine($"User input: {userInput}");
            // No validation or sanitization of input
        }
    }

    public class DatabaseAccessor
    {
        public void GetUserData(string userId)
        {
            string query = $"SELECT * FROM Users WHERE UserId = '{userId}'"; // Vulnerable to SQL injection
            Console.WriteLine(query);
            // Execute the query...
        }
    }





}
