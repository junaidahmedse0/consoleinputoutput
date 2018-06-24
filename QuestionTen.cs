using System;
class QuestionTen
{
 static void Main(string[] args)
 {
    
    int sum=0,num;
    
    Console.WriteLine("Enter number how much you enter");
    num=int.Parse(Console.ReadLine());
    int[] numArr=new int[num];
    for(int i=0;i<num;i++)
    {
      Console.WriteLine("Enter Num is::"+i);
      numArr[i]=int.Parse(Console.ReadLine());
     }
     for(int j=0;j<num;j++)
     {
       
        sum=sum+numArr[j];
     }
     
     Console.WriteLine("The result is"+sum);


 }
}