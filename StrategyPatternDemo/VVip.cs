namespace StrategyPatternDemo
{
    public class VVip : IBuyer
    {
        public double CalPrice(double orderPrice)
        {
            return orderPrice > 30 ? orderPrice * 0.7 : orderPrice;
        }
    }
}
