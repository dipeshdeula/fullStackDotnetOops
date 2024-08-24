using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.OperatorOverloading
{
    public class Price
    {
        //fields
        public int Rupees;
        public int Paise;

        //constructor
        public Price(int rupees, int paise)
        {
            Rupees = rupees;
            Paise = paise;
        }

        //overloading unary operator
        public static Price operator ++(Price price)
        {
            price.Paise = price.Paise + 1;
            return price;
        }

        public static Price operator --(Price price)
        {
            price.Paise--;
            return price;
        }

        //overloading binary operator
        public static Price operator +(Price price1, Price price2)
        {
            Price price = new Price(0, 0);
            price.Rupees = price1.Rupees + price2.Rupees;
            price.Paise = price1.Paise + price2.Paise;
            return price;
        }
    }
}
