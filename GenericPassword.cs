using System;
using System.Security.Cryptography; 
namespace GeneratedPassword
{
    class GenericPassword
    {
        static void Main()
        {
            int count = ReadValidInt("How many passwords to generate? (1 to 100): " , 1 , 100, "Error: please enter an integer between 1 and 100.");
            int length = ReadValidInt("Enter password length (minimum 12 characters): ", 12,128,"Error: length must be an integer between 12 and 128.");
            Console.WriteLine($"\nGenerating: {count} passwords, {length} characters each.\n");
            Generated(count, length);
        }
        static int ReadValidInt(string prompt,int min, int max, string errorMessage)
        {
            while (true) 
            {
                Console.Write(prompt); 
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result) && result >= min && result <= max)
                    return result;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage);
                Console.ResetColor();
            }
        }

        static void Generated(int count, int length)
        {
            string arrayCharPassword = "0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#%^&*?/|";
            for(int i = 0; i<count; i++)
            {
                string password = "";
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasSpecial = false;
                for(int j = 0; j < length; j++)
                {
                    char c = arrayCharPassword[RandomNumberGenerator.GetInt32(0, arrayCharPassword.Length)];
                    password += c;
                        if (char.IsDigit(c))                        
                           hasDigit = true;
                        else if (char.IsUpper(c))
                            hasUpper = true;
                        else if (!char.IsLetterOrDigit(c))
                            hasSpecial = true;                          
                }
                if (hasSpecial && hasDigit && hasUpper)
                {
                    Console.WriteLine("Пароль надежный: " + password);
                }
                else
                {
                    i--;
                }
            }
        }
    }
}
