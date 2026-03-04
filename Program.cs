using System;

public static class Program
{
  public static  double balance = 20;
  public static int choice;
    public static void CheckBalance()
    {
        Console.WriteLine($"Balance: ${balance}");
        Console.WriteLine();
        Console.ReadKey();
    }
    public static void Withdraw()
    {
        Console.Write("Enter amount to withdraw: ");
        double withdraw = Convert.ToDouble(Console.ReadLine());

        if (withdraw <= balance)
        {
            Console.WriteLine($"Succesfully withdrew ${withdraw} from your balance");
            Console.WriteLine();
            balance -= withdraw;
            Console.ReadKey();
        }
        else
        {
            Console.Write("Insufficient balance!");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    public static void Deposit()
    {
        Console.Write("Enter amount to deposit: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        balance += deposit;
        Console.WriteLine($"successfully deposited ${deposit} in to your balance");
        Console.WriteLine();
        Console.ReadKey();
    }
    public static void Introduce()
    {

       do
        {
            Console.Write("1. Check balance\n2. Withdraw\n3. Deposit\n4. Exit\n Choice:  ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CheckBalance();
                    break;
                case 2:
                    Withdraww();
                    break;
                case 3:
                    Depositt();
                    break;
                case 4:
                    break;
               default:
                    Console.WriteLine("invalid input!");
                    Console.WriteLine();
                    break;

            }
            
        } while (choice != 4);
        Console.WriteLine("exiting...");
    }
    public static void Main(string[] args)
    {
        Introduce();
        Console.ReadKey();
    }
}

