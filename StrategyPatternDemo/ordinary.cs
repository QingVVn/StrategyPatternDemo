namespace StrategyPatternDemo
{
    public class Ordinary : IBuyer
    {
        public double CalPrice(double orderPrice)
        {
            return orderPrice * 0.9;
        }
    }
}
