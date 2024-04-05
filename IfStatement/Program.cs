using System;
namespace IfStatement
{
    class Program 
    {
        public static void Main(string[] args)
        {
            char a=char.Parse(Console.ReadLine());
             char b=char.Parse(Console.ReadLine());
           
             if(a=='P' && b=='R')
             {
                Console.WriteLine("Winner: "+a);
             }
             else if(a=='R' && b=='S')
             {
                Console.WriteLine("Winner: "+a);
             }
            else if(a=='S' && b=='P')
             {
                Console.WriteLine("Winner: "+a);
             }
            else if(a=='P' && b=='S')
             {
                Console.WriteLine("Winner: "+a);
             }
            else if(a=='R' && b=='P')
             {
                Console.WriteLine("Winner: "+a);
             }
            else if(a=='S' && b=='R')
             {
                Console.WriteLine("Winner: "+a);
             }


        }
    }
}
