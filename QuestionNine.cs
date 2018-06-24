using System;
class QuestionNine
{
 static void Main(string[] args)
 {
    int[] numArr=new int[5];
    int sum=0;
    for(int i=0;i<5;i++)
    {
      Console.WriteLine("Enter Num is::",i);
      numArr[i]=int.Parse(Console.ReadLine());
     }
     for(int j=0;j<5;j++)
     {
       
        sum=sum+numArr[j];
     }
     
     Console.WriteLine("The result is"+sum);


 }
}