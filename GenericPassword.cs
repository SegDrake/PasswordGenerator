using System;
namespace GeneratedPassword
{
    class GenericPassword
    {
        static void Main()
        {
            int count = ReadValidInt("Сколько паролей сгенерировать? (от 1 до 100): " , 1 , 100, "Ошибка: введите целое число от 1 до 100.");
            int length = ReadValidInt("Введите длину пароля(минимум 12 символов): ", 12,128,"Ошибка: длина должна быть целым числом от 12 до 128.");
            Console.WriteLine($"\nБудет сгенерировано: {count} паролей, длина каждого {length} символов.\n");
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
            Random ram = new Random();
            for(int i = 0; i<count; i++)
            {
                string password = "";
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasSpecial = false;
                for(int j = 0; j < length; j++)
                {
                    char c = arrayCharPassword[ram.Next(0, arrayCharPassword.Length)];
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
