using System;
namespace ReadWrite{



class Program
{
    public static void Main(string[] args)
    {
        //Getting input
        Console.Write("Enter your Name:");
        string name= Console.ReadLine();
        Console.Write("Enter your FatherName:");
        string fatherName= Console.ReadLine();
        // Printing the result
        
        Console.WriteLine(name+" "+fatherName);

        //placeholder
        Console.WriteLine("{0} {1}",name,fatherName);
        Console.WriteLine("{0} {1}",fatherName,name);
        Console.WriteLine("{1} {0}",name,fatherName);

        //interplation

       Console.WriteLine($"{name} {fatherName}");
       Console.ReadKey();

    }
}
}