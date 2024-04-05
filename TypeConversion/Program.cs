using System;
namespace TypeConversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a Number1:");
            int Number1=int.Parse(Console.ReadLine());  //int.parse used for type conversion string to int
            //Console.WriteLine("Your number is:" +Number);
            Console.WriteLine("Enter a Number2:");
            int Number2=int.Parse(Console.ReadLine());
            Console.WriteLine(Number1+Number2);

            Console.WriteLine("Enter the double:");
            double Number3=int.Parse(Console.ReadLine());
            Console.WriteLine(Number3);

            int n1=Convert.ToInt32(null); // it has no any value ie null so retun 0
            Console.WriteLine(n1);

            int n2=int.Parse(null); // through exception
            Console.WriteLine(n2);
    }
   
}
}