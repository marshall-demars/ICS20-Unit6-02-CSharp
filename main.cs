// Created by: Marshall
// Created on: May 2022
//
// This program saves to local storage

using System;
using System.Threading.Tasks;
using System.IO;

class Program
{
    public static async Task Main()
    {
        int counter = 0;
        string repeatQuestion;

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Do you want to quit the program?");
            Console.WriteLine("");
            Console.WriteLine("Type 'yes' to end the program or type 'no' to add 1 to the counter");
            repeatQuestion = Convert.ToString(Console.ReadLine());
            if (repeatQuestion == "yes")
            {
                break;
            }
            counter++;
            await File.WriteAllTextAsync("WriteText.txt", counter.ToString());
            // write to file
        }
        // end program
        Console.WriteLine("");
        Console.WriteLine("The program has ended!");
        Console.WriteLine("\nDone.");
    }
}