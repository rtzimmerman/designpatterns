using System;
namespace DesignPatterns.StructuralPatterns.FacadePattern
{
    public class Bank
    {
        public bool HasSufficientSaving(Customer customer, int loanAmount)
        {
            Console.WriteLine("Who saves anyway? Am I right??");
            return true;
        }
    }
}
