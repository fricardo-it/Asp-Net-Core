namespace SolidConcepts._2_OCP.OCP_Solving
{
    public class DebitCheking : DebitOperation
    {
        public override string Debit(decimal amount, string account)
        {
            return TransactionIdentifier;
            
        }
    }
}
