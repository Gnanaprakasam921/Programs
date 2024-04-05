using System;
namespace Array
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int i,j;
                int row=3;
                int col=3;
                int[,] arr=new int[row,col];
                //  int[,] arr1=new int[row,col];
                //  int[,] arr2=new int[row,col];
                for(i=0;i<row;i++)
                {
                    for( j=0;j<col;j++)

                    {
                        arr[i,j]=int.Parse(Console.ReadLine());
                        // arr1[i,j]=int.Parse(Console.ReadLine());
                        //  arr2[i,j]=int.Parse(Console.ReadLine());
                    }
                }
                for(i=0;i<row;i++)
                {
                    for(j=0;j<col;j++)
                    {
                        Console.Write(arr[i,j]+" ");
                    }
                    Console.WriteLine();
                }
                


        }


              
          
          
          
          
          
          
          
          
          
          
          
          
          
          
           
    }

}
