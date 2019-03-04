using System;
using DesignPatterns.BehavioralPatterns.StrategyPattern;
using DesignPatterns.StructuralPatterns.FacadePattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoStrategyPattern();
            DemoFacadePattern();
            Console.ReadKey();
        }

        public static void DemoStrategyPattern()
        {
            // Two contexts following different strategies

            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
        }

        public static void DemoFacadePattern()
        {
            // Facade

            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer

            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
