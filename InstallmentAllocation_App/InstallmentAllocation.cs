using System;


namespace InstallmentAllocation_App
{
    public class InstallmentAllocation
    {
        private const double FourPercent = 4d / 100;
        private const double FivePercent = 5d / 100;
        private const double TenPercent = 10d / 100;
        private const double TwentyPercent = 20d / 100;
        private const double TwentyFivePercent = 25d / 100;
        private const double FiftyPercent = 50d / 100;
        private static  DateTime _Today;
        public InstallmentAllocation()
        {
           
        }

        //daily plan
        // daily plan has an 4% intallmental payment so we will compare it with 100%
        
        public static void DailyPlan(decimal Cash, string user, string product)
        {
            Console.Clear();
           
            decimal percentage = (decimal)(FourPercent);
            _Today = DateTime.Now;
            
            decimal installment = Cash * percentage;

            decimal i = 0;

           for (i = installment; i <= Cash ; i += installment)
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
            decimal percentage = (decimal)(FivePercent);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash ; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved (Expected) ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
   
                _Today = _Today.AddDays(7);
            }
      
        }
        //biweeky
        public static void BiWeeklyPan(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(TenPercent);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash ; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved  (Expected) ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
    
                _Today = _Today.AddDays(14);
            }
        }

        //monthly
        public static void Monthly(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(TwentyPercent);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash ; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved  (Expected) ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
          
                _Today = _Today.AddMonths(1);
            }
        }
        //6-month
        public static void SixMonthPlan(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(TwentyFivePercent);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash ; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved  (Expected) ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
              
                _Today = _Today.AddMonths(6);
            }
        }
        //one year plan
        public static void OneYearPlan(decimal Cash, string user, string product)
        {
            decimal percentage = (decimal)(FiftyPercent);
            _Today = DateTime.Now;

            decimal installment = Cash * percentage;

            for (decimal i = installment; i <= Cash ; i += installment)
            {
                Console.WriteLine($"Appointed Date To Recieve payment {_Today.ToLongDateString()}," +
                    $"  Amount Expected ₦ {installment},Total Amount Recieved  (Expected) ₦ {i} " +
                    $" For Product {product} by Customer {user.ToUpper()}");
             
                _Today = _Today.AddYears(1);
            }
        }
        //private static decimal Percentage()
        //{ 

        //}

    }
}

