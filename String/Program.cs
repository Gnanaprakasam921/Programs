using System;
using System.Reflection.PortableExecutable;
namespace String
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int i,temp;
            string str=Console.ReadLine();
            int ln=str.Length;
            for(i=0;i<ln-1;i++)
            {
                if(i%2==0)
                {
                    temp=str[i];
                    str[i]=str[i+1];
                }
            }
        }
    }
}
