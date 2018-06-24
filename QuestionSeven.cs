using System;
class QuestionSeven
{

  static void Main(string[] args)
  {

   int a,b,c,d,e;
   bool parseSucceed=false;
   do{
       Console.WriteLine("Enter first num");
       parseSucceed=Int32.TryParse(Console.ReadLine(),out a);
     }
     while(!parseSucceed);
   do{
       Console.WriteLine("Enter second num");
       parseSucceed=Int32.TryParse(Console.ReadLine(),out b);
     }
     while(!parseSucceed);
   do{
       Console.WriteLine("Enter third num");
       parseSucceed=Int32.TryParse(Console.ReadLine(),out c);
     }
     while(!parseSucceed);
   do{
       Console.WriteLine("Enter fourth num");
       parseSucceed=Int32.TryParse(Console.ReadLine(), out d);
     }
     while(!parseSucceed);
   do{
       Console.WriteLine("Enter first num");
       parseSucceed=Int32.TryParse(Console.ReadLine(),out e);
     }
     while(!parseSucceed);
     
     Console.WriteLine("num",a,b,c,d,e);





   }




}