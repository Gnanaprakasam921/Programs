using System;
namespace DoWhile 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int arm=0;
                int m;
                //int i=0;
                int n=500;
                int i=1;
                do{
                   // i=i+1;
                      
                   if(i<=9)
                    {
                        Console.WriteLine(i);
                    }
                    // if(i<100 && i>=10)
                    // {
                    // m=i%10;
                    // arm=arm+(m*m);
                    // i=i/10;
                    
                      
                  //  }
                  int b=i;
                  if(i<999 && i>100)
                  {
                while(b!=0)
                    //if(i<999 && i>100)
                    {
                    m=b%10;
                    arm=arm+(m*m*m);
                    b=b/10;
                    }
                  }
                    // else if(i>1000)
                    // {
                    // m=i%10;
                    // arm=arm+(m*m*m*m);
                    // i=i/10;
                    // }

                     if(i==arm)
                        {
                            Console.WriteLine(i);
                        }
                        i++;
                        arm=0;
                    
                }while(i<=n);

                //  {
                //     m=i%10;
                //     arm=arm+(m*m*m);
                //     i=i/10;
                //     }

                  
                
        }
    }
}
