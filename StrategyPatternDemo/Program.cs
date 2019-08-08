using System;

namespace StrategyPatternDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBuyer strategy = new Vip();
            Cashier cashier = new Cashier(strategy);
            Console.WriteLine("Vip:" + cashier.Cal(500));

            strategy = new SuperVip();
            cashier = new Cashier(strategy);
            Console.WriteLine("SuperVip:" + cashier.Cal(500));
            Console.ReadKey();
        }

        public double CalPriceForA(double orderPrice, BuyerType buyerType)
        {
            if (buyerType == BuyerType.SuperVip)
            {
                return orderPrice * 0.8;
            }
            if (buyerType == BuyerType.Vip)
            {
                return orderPrice * 0.85;
            }
            return orderPrice * 0.9;
        }

        public double CalPriceForB(double orderPrice, BuyerType buyerType)
        {
            if (buyerType == BuyerType.VVip)
            {
                return orderPrice * 0.7;
            }
            if (buyerType == BuyerType.SuperVip)
            {
                return orderPrice * 0.8;
            }
            if (buyerType == BuyerType.Vip)
            {
                return orderPrice * 0.85;
            }
            return orderPrice * 0.9;
        }

        public double CalPriceForC(double orderPrice, BuyerType buyerType)
        {
            if (buyerType == BuyerType.VVip && orderPrice>30)
            {
                return orderPrice * 0.7;
            }
            if (buyerType == BuyerType.SuperVip)
            {
                return orderPrice * 0.8;
            }
            if (buyerType == BuyerType.Vip)
            {
                return orderPrice * 0.85;
            }
            return orderPrice * 0.9;
        }
    }
}
