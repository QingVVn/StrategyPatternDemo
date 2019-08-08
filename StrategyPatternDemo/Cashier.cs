namespace StrategyPatternDemo
{
    public class Cashier
    {
        private IBuyer Buyer;

        public Cashier(IBuyer buyer)
        {
            Buyer = buyer;
        }

        public double Cal(double orderPrice)
        {
            return this.Buyer.CalPrice(orderPrice);
        }
    }
}
