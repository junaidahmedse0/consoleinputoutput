using System;
class QuestionTwo
{
 	static void Main(string[] args)
	{
	   const double PI=3.14;
	   int radius=0;
           double area=0;
 	   double perimeter=0;
           Console.WriteLine("Enter radius:: ");
	   radius=int.Parse(Console.ReadLine());
           area=PI*(radius*radius);
 	   perimeter=2*(PI*radius);
           Console.WriteLine("Ther area is:: "+area);
           Console.WriteLine("The Perimeter is::"+perimeter);
	   

	}






}