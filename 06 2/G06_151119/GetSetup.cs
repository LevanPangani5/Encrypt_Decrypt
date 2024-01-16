using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace G06_151119
{
    class GetSetup
    {
         public static void GetFileNames (out string inputFile , out string outputFile)
        {
           // inputFile = @"D:\G03_3.txt";
            do
            {
              Console.Write("Enter input file name :");
              inputFile = Console.ReadLine();
            } while (!File.Exists(inputFile));
              Console.WriteLine("Enter output file name:");
            outputFile = Console.ReadLine();           
          if (!File.Exists(outputFile))
          {
             outputFile = @"D:\G06_ 3.txt";
            FileStream tmp = new FileStream(@"D:\G06_ 3.txt", FileMode.Create);
            Console.WriteLine($"File you enterd dosen't exist so i created one called {outputFile}");
          }
          
        }

       public static  string GetPassword()
        {
            string password;          
            Console.Write("Enter password:");
            password = Console.ReadLine();
              return password;
           
        }

         public static ConsoleKey GetCommand()
        {
            Console.WriteLine("Press 1 if you want Encrypting");
            Console.WriteLine("Press 2 if you want Decrypting");
            ConsoleKey Commandkey;
            do
            {
                Console.WriteLine("Enter  command:");
                Commandkey = Console.ReadKey(true).Key;
            } while (Commandkey != ConsoleKey.D1 && Commandkey != ConsoleKey.D2);

            if (Commandkey == ConsoleKey.D1)
                Console.WriteLine("Encrypting text data");
            else
            {
                Console.WriteLine("Decrypting text data");
            }

            return Commandkey;

        }
    }
}
