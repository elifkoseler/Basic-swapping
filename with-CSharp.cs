using System;

    class Swapping
    {
        static void Main(string[] args){
      
        Console.WriteLine("Please enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a: "+ a + " b: " + b + "\n");

        Console.ReadLine();
        
    }
   }
