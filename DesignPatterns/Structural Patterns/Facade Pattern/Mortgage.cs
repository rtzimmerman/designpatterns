using System;
namespace DesignPatterns.StructuralPatterns.FacadePattern
{
    //Facade class
    //Mortgage application knows which subsystems to call
    public class Mortgage
    {
        private Loan Loan = new Loan();
        private Bank Bank = new Bank();
        private Credit Credit = new Credit();

        public bool IsEligible(Customer customer, int loanAmount)
        {
            //Initiating credit worthiness check
            bool eligibilty = true;

            if (!this.Bank.HasSufficientSaving(customer, loanAmount))
            {
                eligibilty = false;
            }
            else if (!this.Credit.HasGoodCredit(customer))
            {
                eligibilty = false;
            }
            else if (!this.Loan.HasNoBadLoans(customer))
            {
                eligibilty = false;
            }

            return eligibilty;
        }
    }
}
