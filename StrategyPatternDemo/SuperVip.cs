namespace StrategyPatternDemo
{
    public class SuperVip : IBuyer
    {
        public double CalPrice(double orderPrice)
        {
            return orderPrice * 0.8;
        }
    }
}
