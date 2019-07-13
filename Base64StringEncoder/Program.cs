using System;

namespace Base64StringEncoder
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "input";
            Console.WriteLine("This program allows you to base64 encode strings. Enter 0 when done.");
            Console.WriteLine();
            while (!input.Equals("0"))
            {
                Console.WriteLine();
                Console.WriteLine("Enter secret to encode or 0 to exit. ");
                Console.WriteLine();

                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && !input.EndsWith("0"))
                    Console.WriteLine(GetEncodedString(input));
                Console.WriteLine();
            }
            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
        }



        private static string GetDecodedString(string input)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
        }

        private static string GetEncodedString(string input)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));
        }
    }
}
