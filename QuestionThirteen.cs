using System;
class QuestionThirteen 
{
   static void Main(string[] args)
   {
        Console.Write("Enter Last Number");
        int length=Int32.Parse(Console.ReadLine());
        double sum=1.0;
        for (int i=2;i<=length;i++)
        {


              sum+=(1.0/i);
             Console.WriteLine("{0:F3}",sum);

       }
       


   }






}

