using System;
namespace DesignPatterns.StructuralPatterns.FacadePattern
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine("No bad loans");
            return true;
        }
    }
}
