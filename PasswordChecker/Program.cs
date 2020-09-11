using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Password Checker!");
            bool done = false;
            while (!done) {
                // Obtain user input from console
                Console.Write("Please enter a password via the console: ");
                string pswd = Console.ReadLine();

                // Save input string length for character count
                int n = pswd.Length;

                // Count uppercase and lowercase letters, exclamation points
                int upper = 0;
                int lower = 0;
                for (int i = 0; i < n; i++) 
                {
                    if (Char.IsUpper(pswd, i)) upper++;
                    if (Char.IsLower(pswd, i)) lower++;
                }

                // Check if there is at least one lowercase letter
                if (lower >= 1) 
                {
                    // Check if there is at least one uppercase letter
                    if (upper >= 1)
                    {
                        // Check to see if the password length is at least 7
                        if (n >= 7)
                        {
                            // Check to see if the password length is at most 12
                            if (n <= 12)
                            {
                                // Check to see if the password has an "!"
                                if (pswd.IndexOf('!') != -1)
                                {
                                    Console.WriteLine("Success: Password valid and accepted!");
                                    done = true;
                                }
                                else
                                {
                                    Console.WriteLine("Error: Must have a !");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: Must have no more than 12 characters");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Must have at least 7 characters");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Must have 1+ uppercase letter");
                    }
                } else 
                {
                    Console.WriteLine("Error: Must have 1+ lowercase letter");
                }

            }
        }
    }
}
