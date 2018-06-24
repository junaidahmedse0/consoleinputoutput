using System;
class QuestionFive
{
  static void Main(string[] args)
  {

      int num1,num2;
      int count=0;

      Console.WriteLine("Enter first Num");
      num1=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Second Num");
      num2=int.Parse(Console.ReadLine());
      for(int i=num1;i<num2;i++)
      {
        if(i%5==0)
        {
         
           count++;

        }

 
       }
       Console.WriteLine("The total number of divisable"+count);



   


}





}