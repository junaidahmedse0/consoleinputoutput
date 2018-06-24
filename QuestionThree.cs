using System;
class QuestionThree
{
     static void Main(string[] args)
    {
      string companyName,website,phoneNumber,faxNumber;
      int mgrID;
      string mgrName,mgrSurName,mgrPhoneNumber;

      Console.WriteLine("Enter Company Details");
      Console.WriteLine("Enter Company Name");
      companyName=Console.ReadLine();
      Console.WriteLine("Enter website Name");
      website=Console.ReadLine();
      Console.WriteLine("phone Number");
      phoneNumber=Console.ReadLine();
      Console.WriteLine("Fax Number");
      faxNumber=Console.ReadLine();
      Console.WriteLine("Manager ID");
      mgrID=int.Parse(Console.ReadLine());
      

      Console.WriteLine("Enter Manager Details");
     Console.WriteLine("Enter Manger Name");
     mgrName=Console.ReadLine();
     Console.WriteLine("Enter manger surName");
     mgrSurName=Console.ReadLine();

     Console.WriteLine("Enter manager Phone Number");
     mgrPhoneNumber=Console.ReadLine();
     Console.WriteLine("Company Detail");
     Console.WriteLine("Company Name {0} website {1} phone Number= {2} fax Number {3} manager ID {4}",companyName,website,phoneNumber,faxNumber,mgrID);
     Console.WriteLine("Manager Detail");
     Console.WriteLine("Manager name {0} manager SurName {1} manager PhoneNumber {2}",mgrName,mgrSurName,mgrPhoneNumber);
    } 

}