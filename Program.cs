using System.Security.Cryptography.X509Certificates;

namespace Challenge3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word to test if palidrome");
            Console.WriteLine(isPalidrome(Console.ReadLine())); 


            bool isPalidrome(string userInput)
            {
                for (int i = 0; i < userInput.Length / 2; i++)
                {
                    if (userInput[i] != userInput[userInput.Length - i - 1])
                            {
                        return false;
                    }
                }
                return true; 
            }
        }
    }
}
