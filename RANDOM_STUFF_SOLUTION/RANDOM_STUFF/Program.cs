using System;

namespace RANDOM_STUFF
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int Number = rdm.Next();

            Console.WriteLine(Number);

            Console.ReadLine();

        }
       
        
      
    }
   
   
}
