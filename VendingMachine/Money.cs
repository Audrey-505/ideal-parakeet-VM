namespace VendingMachines
{
    public class Money
    {
        public decimal Value;

        public Money (decimal value)
        {
            this.Value = value;
        }

        public static Money Nickel = new Money(.05m);
        public static Money Dime = new Money(.10m);
        public static Money Quarter = new Money(.25m);
    }
}
