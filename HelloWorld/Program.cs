using System;
namespace HelloWorld;  //HelloWorld is a folder name  after name space methed paranthisis dosnt required using ;

    class Program   //program is program file name
    {
        public static void Main(string[] args)
        {
        //     //With argument with funciton
            
        //   a=10,b=20;
        //    int res=mul(a,b);
        //    Console.WriteLine(res)
        // }
        
        //    static int mul(int x,int y)
        //    {
        //     int c=x*y;
        //     return c; 
        //    }
        // }
        //    //without return with agrument 
        //    public void div(double x,double y)
        //    {
        //     double d=x/y;
        //     Console.WriteLine(d);
        //    }

        
        //  method 1

            int a=int.Parse(Console.ReadLine());
                 int b=int.Parse(Console.ReadLine());
                 Console.WriteLine(Sum(a,b));
               static int Sum(int num1,int num2)
               {
                int c=num1+num2;
                return c;
               }


        }
        
        
    }

