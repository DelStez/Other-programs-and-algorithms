using System;

using System.IO;

namespace GenerateNumbers
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла: ");
            string nameFile = @"C:\Users\Kanda\\\OneDrive\\Рабочий стол\\" + Console.ReadLine() + ".txt";
            Console.WriteLine("Всего чисел: "); int allNumbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальное возможное значение: "); int maxVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минимальное возможное значение: "); int minVal = Convert.ToInt32(Console.ReadLine());
            var random = new Random();
           using (StreamWriter file = new StreamWriter(nameFile)) 
           {
                for (int ctr = 1; ctr <= allNumbers; ctr++)
                {   
                    
                    double d = Math.Round(random.Next(minVal, maxVal) * (random.NextDouble() > 0.5 ? -1 : 1)
* (random.NextDouble() > 0.5 ? random.NextDouble() : 1), random.Next(0, 4));
                    file.Write(d + " ");
                    if (ctr % 5 == 0) file.Write("\n");
                }
           }

        }
    }
}
