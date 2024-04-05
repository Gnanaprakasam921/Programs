using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                int sum=0,m=0;
                int i=1;
                int start=int.Parse(Console.ReadLine());
                int diff=int.Parse(Console.ReadLine());
                int end=int.Parse(Console.ReadLine());
                while(i<=end)
                {
                    m=start+diff;
                    sum=m+sum;
                    i++;
                    
                }
                Console.WriteLine(sum+start);

            }
        }
            