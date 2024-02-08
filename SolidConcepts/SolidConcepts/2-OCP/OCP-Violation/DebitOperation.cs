namespace SolidConcepts._2_OCP.OCP_Violation
{
    public class DebitOperation
    {
        public void Debit(decimal amount, string account, AccountType type)
        {
            if (type == AccountType.Checking) 
            { 
                // Make debit    
            }

            if (type == AccountType.Savings)
            {
                // Validate Account Birth
                // Make debit
            }
        }
    }
}
