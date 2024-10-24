using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculate.Others
{
    internal class Temp
    {

        public class WeakHashing
        {
            public string GenerateMD5Hash(string input)
            {
                // Insecure hashing algorithm (MD5)
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }
        }


        public class DeadlockExample
        {
            private readonly object _lock1 = new object();
            private readonly object _lock2 = new object();

            public void Method1()
            {
                lock (_lock1)
                {
                    lock (_lock2)
                    {
                        // Critical section
                        Console.WriteLine("Method1 executed");
                    }
                }
            }

            public void Method2()
            {
                lock (_lock2)
                {
                    lock (_lock1)
                    {
                        // Critical section
                        Console.WriteLine("Method2 executed");
                    }
                }
            }

        }

        public class NullReferenceExample
        {
            public void PrintUserDetails(string name)
            {
                // Risk of null reference if 'name' is null
                Console.WriteLine("User: " + name.ToUpper());
            }
        }



        public class UnreleasedResources
        {
            public void WriteToFile(string fileName, string content)
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine(content);
                // Stream and file not disposed or closed
            }
        }

        public class NonThreadSafeExample
        {
            private static int _counter = 0;

            public void IncrementCounter()
            {
                // Non-thread-safe increment operation
                _counter++;
            }

            public int GetCounter()
            {
                return _counter;
            }
        }


        public class DeprecatedApiUsage
        {
            public void UseObsoleteMethod()
            {
                // This method is marked as obsolete
                AppDomain domain = AppDomain.CreateDomain("NewDomain");
                Console.WriteLine("Domain created: " + domain.FriendlyName);
            }
        }

    }
}
