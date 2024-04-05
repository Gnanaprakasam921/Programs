using System;
namespace TailorSeries
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int fact=1,m;
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                fact=fact*1;
            }
            for(int i=0;i<n;i++)
            {
                m=(Math.Pow(2,i))/fact(i);

            }

        }
    }
}
