namespace StrategyPatternDemo
{
    public class Vip : IBuyer
    {
        public double CalPrice(double orderPrice)
        {
            return orderPrice * 0.85;
        }
    }
}
