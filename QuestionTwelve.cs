
using System;
class QuestionTwelve
{

  static void Main(string[] args)
  {
    int i;
    int fab=0;
    int temp1=0,temp2=0;
    for(i=0;i<100;i++)
    {

       if(i==0)
        {
            temp1=i;
            Console.WriteLine("   "+i);
            //continue;

        }
       else if(i==1)
       {

          temp2=i;
          Console.WriteLine("  "+i);
         // continue;

       }
       else
       {
           fab=temp2+temp1;
           temp1=temp2;
           temp2=fab;
           
           Console.WriteLine("  "+fab);
          // continue;
       }
  
       
       



    }




   }



}