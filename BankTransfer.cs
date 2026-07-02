namespace CG_BTBuoi14
{
    public class BankTransfer : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Bank Transfer.");
        }
    }
}
