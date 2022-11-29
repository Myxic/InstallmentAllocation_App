using System;
using System.ComponentModel;
using System.Data.Common;

namespace InstallmentAllocation_App;
class Program
{
    static void Main(string[] args)
    {
     
        Run();
    }
    private static void Run()
    {
        Dictionary<string, decimal> Records = new Dictionary<string, decimal>() { };
        
        string User = Username();
        string product = Product();
        decimal Fee = Amount();
        //Console.WriteLine(Fee);
        Records.Add(User, Fee);
        Console.Clear();
        Console.WriteLine("Note: 5% charges fees are attached to installmental payments");
        Option(Records, User, product);






    }

    private static string Username()
    {
        Console.Write("Enter Customer Name: ");
        string? Customer = Console.ReadLine();
      
        if (Customer.Trim() == "")
        {
            Console.Clear();
            Console.WriteLine("Invalid");
            return Username();
        }
        
        return Customer.Trim();
    }
    private static string Product()
    {
        Console.Write("Enter Product Name: ");
        string? ProductItem = Console.ReadLine();

        if (ProductItem.Trim() == "")
        {
            Console.Clear();
            Console.WriteLine("Invalid");
            return Product();
        }

        return ProductItem.Trim();
    }
    private  static decimal Amount()
    {
        Console.Write("Enter Amount Owed :  ₦ ");
        string? Fee = Console.ReadLine();



        bool IsValid = decimal.TryParse(Fee, out decimal ValidAmount);
        if (!IsValid || ValidAmount <= 0)
        {
            Console.Clear();
            Console.WriteLine("Invalid Format");
            return Amount();
        }
        if (IsValid)
        {
            ValidAmount = Convert.ToDecimal(Fee);
            
        }


        return ValidAmount;
       

    }
    private static void Option(Dictionary<string, decimal> Records, string user, string product)
    {
        //Adding the extra installment fee to the total amount
        decimal percentage = (decimal)(5d / 100);

        decimal TotalAmount = (percentage * Records[user]) + Records[user];


        Console.WriteLine("Select a Plan ");
        Console.WriteLine("4% installmental Payment with Daily Plan, Type 1 \n "+
            "5% installmental Payment with Weekly Plan , Type 2 \n"  +
            "10% installmental Payment with Bi-Weekly Plan , Type 3 \n" +
            "20% installmental Payment with Monthly Plan , Type 4 \n" +
            "25% installmental Payment with Six-Month Plan , Type 5 \n"+ 
            "50% installmental Payment with Yearly , Type 6");
        string? plan = Console.ReadLine();
        Console.Clear();


        switch (plan)
        {
            case "1":
                InstallmentAllocation.DailyPlan(Cash: TotalAmount, product:product, user:user);
                break;
            case "2":
                InstallmentAllocation.WeeklyPlan(Cash: TotalAmount, product: product, user: user);
                break;
            case "3":
                InstallmentAllocation.BiWeeklyPan(Cash: TotalAmount, product: product, user: user);
                break;
            case "4":
                InstallmentAllocation.Monthly(Cash: TotalAmount, product: product, user: user);
                break;
            case "5":
                InstallmentAllocation.SixMonthPlan(Cash: TotalAmount, product: product, user: user);
                break;
            case "6":
                InstallmentAllocation.OneYearPlan(Cash: TotalAmount, product: product, user: user);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid Plan");
                Option(Records,user, product);
                break;
        }
    }
}

