namespace SolidConcepts._2_OCP.OCP_Solving
{
    public abstract class DebitOperation
    {
        public string TransactionIdentifier { get; set; }
        public abstract string Debit(decimal amount, string account);
    }
}
