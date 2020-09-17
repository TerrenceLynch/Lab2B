using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("What is the sales person's name?");
    string name = Console.ReadLine();
    Console.WriteLine("What is the sales amount for " + name + "?" );
    double sales_amount = Convert.ToDouble(Console.ReadLine());
    double sales_commision= 200 + (0.09 * sales_amount);
   
    
      if (sales_amount >= 0 && sales_amount <= 2999)
      {
      Console.WriteLine("The sales commison for " + name + " is $" + sales_commision);
      Console.WriteLine("The Preformace of " + name + " is Poor from these numbers.");
      }
      else if (sales_amount >= 3000 && sales_amount <= 4999)
      {
      Console.WriteLine("The sales commison for " + name + " is $" + sales_commision);
      Console.WriteLine("The Preformace of " + name + " is Average from these numbers.");
      }
      else if (sales_amount >= 5000 && sales_amount <= 9999)
      {
      Console.WriteLine("The sales commison for " + name + " is $" + sales_commision);
      Console.WriteLine("The Preformace of " + name + " is Good from these numbers.");
      }
      else if (sales_amount >= 10000 && sales_amount <= 14999)
      {
      Console.WriteLine("The sales commison for " + name + " is $" + sales_commision);
      Console.WriteLine("The Preformace of " + name + " is Excellent from these numbers.");
      }     
      else if (sales_amount >= 15000)
      {
      Console.WriteLine("The sales commison for " + name + " is $" + sales_commision);
      Console.WriteLine("The Preformace of " + name + " is Outstanding from these numbers.");
      }
      else 
      {

      }
    }

  }
