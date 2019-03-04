using System;
namespace DesignPatterns.StructuralPatterns.FacadePattern
{
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine("Credit check approved. note: sub-prime");
            return true;
        }
    }
}
