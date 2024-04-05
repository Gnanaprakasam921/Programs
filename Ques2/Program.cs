using System;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
namespace Ques2
{
    class Program 
    {
        public static void Main(string[] args)
        {
            // 2nd question

            // string s="";
            //    // string str2;
            //     int n=int.Parse(Console.ReadLine());
            //     string str=Console.ReadLine();
            //     int ln=str.Length;
            //  for(int i=0;i<ln;i++)
            //  //foreach(char i in str)
            //    {

            //     //Console.WriteLine(str[2]);
            //     if ((i+1)%n==0)
            //     {
            //         s=s+str[i];
            //     }
            //    }
            //    Console.WriteLine(s.Trim());



            //  3rd program


            //  string s="";
            //     int n=int.Parse(Console.ReadLine());
            //     string str1=Console.ReadLine();
            //     int ln=str1.Length-1;
            //     string str2=Console.ReadLine();
            //     for(int i=ln;i>=0;i--)
            //     {
            //         s=s+str1[i];
            //     }

            //     //Console.WriteLine(s);
            //     string trim=s.Trim();
            //     if(s==str2)
            //     {
            //         Console.WriteLine("yes");
            //     }
            //     else
            //     {
            //         Console.WriteLine("no");
            //     }

            // 6th question

            // int count=0;
            //     int i;
            //     string s=Console.ReadLine();
            //     int ln=s.Length;
            //     for(i=0;i<ln;i++)
            //     //foreach(Char i in s)
            //     {
            //         if(s[i]=='0'|| s[i]=='1'|| s[i]=='2'|| s[i]=='3'|| s[i]=='4'|| s[i]=='5'||s[i]=='5'|| s[i]=='7'|| s[i]=='8'|| s[i]=='9')
            //             {
            //                 count=count+(s[i]-'0');
            //             }

            //     }
            //     Console.WriteLine(count);

            // Ques 4
            //   int i=0;
            //   string sp="";
            //   int a=10;
            //    int n=int.Parse(Console.ReadLine());
            //    string s=Console.ReadLine();
            //    string[] str=s.Split(",");
            //    int[] val=new int[n];
            //    for(i=0;i<n;i++)
            //    {
            //     val[i]=int.Parse(str[i]);
            //    }
            //    for(i=0;i<n;i++)
            //    {
            //     if(val[i]==i)
            //     {
            //          a=20;
            //         sp=sp+" "+(str[i]);
            //     }
            //    }
            //    if (a==20)
            //    {
            //     Console.WriteLine(sp.Trim());
            //    }
            //    else{
            //     Console.WriteLine("-1");

            //    }


            string s="1";
            int s1=int.Parse(s);
            string s2="3";
            int s3=int.Parse(s2);
            Console.WriteLine(s1+s3);

               
             
        }
    }
}
