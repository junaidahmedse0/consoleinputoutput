using System;
class QuestionEigth
{
  static void Main(string[] args)
  {

     int[] nums=new int[5];
     for(int i=0;i<5;i++)
     {
           Console.WriteLine("Enter number is ::"+i);
          nums[i]=int.Parse(Console.ReadLine());
   

      }  
      int greatest=nums[0];
     for(int j=0;j<5;j++)
     {


         if(nums[j]>greatest)
         {
             greatest=nums[j];
         }

     }
    Console.WriteLine("The greates number is ::"+greatest);



   }






}