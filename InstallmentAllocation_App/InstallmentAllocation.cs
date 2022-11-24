using System;


namespace InstallmentAllocation_App
{
    public class InstallmentAllocation
    {
        private static  DateTime _Today;
        public InstallmentAllocation()
        {
           
        }

        //daily plan
        // daily plan has an 4% intallmental payment so we will compare it with 100%
        
        public static void DailyPlan(decimal Cash, string user, string product)
        {
            Console.Clear();
            decimal percentage = (decimal)(4d / 100);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            decimal i = 0;

           for (i = installment; i <= Cash + 1; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
                _Today = _Today.AddDays(1);
            }
   
        }
        //weekyplan
        public static void WeeklyPlan(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(5d / 100);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash + 1; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
   
                _Today = _Today.AddDays(7);
            }
      
        }
        //biweeky
        public static void BiWeeklyPan(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(10d / 100);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash + 1; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
    
                _Today = _Today.AddDays(14);
            }
        }

        //monthly
        public static void Monthly(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(20d / 100);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash + 1; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
          
                _Today = _Today.AddMonths(1);
            }
        }
        //6-month
        public static void SixMonthPlan(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(25d / 100);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash + 1; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
              
                _Today = _Today.AddMonths(6);
            }
        }
        //one year plan
        public static void OneYearPlan(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(50d / 100);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash + 1; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
             
                _Today = _Today.AddYears(1);
            }
        }
        //private static double Allocation(int num)
        //{
        //    double FullPrecent = 100d;
        //    double FractionAllocation = num / FullPrecent;

        //    return FractionAllocation;
        //}

    }
}

