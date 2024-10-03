using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
           
            Console.Write("Введіть шлях до вихідного файлу: ");
            string inputFilePath = Console.ReadLine();

            Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
            string outputFilePath = Console.ReadLine();

            
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Помилка: вихідний файл не існує.");
                return;
            }

            
            File.Copy(inputFilePath, outputFilePath, true); 

            
            Console.WriteLine("Файл успішно скопійовано!");
        }
        catch (Exception ex)
        {
     
            Console.WriteLine("Сталася помилка під час копіювання файлу: " + ex.Message);
        }
    }
}
