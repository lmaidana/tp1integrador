using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOptionsTP.Classes
{
    internal class Bill
    {
        private const double PRICE_FRENCH_FRIES = 1;
        private const double PRICE_HOT_DOG = 2;
        private const double PRICE_SODA = 0.75;
        private const double TIP_PRICE = 0.1;

        public Bill(int frenchFriesAmount, int hotDogAmount, int sodasAmount)
        {
            FrenchFriesAmount = frenchFriesAmount;
            HotDogAmount = hotDogAmount;
            SodasAmount = sodasAmount;
        }

        private int FrenchFriesAmount { get; set; }
        private int HotDogAmount { get; set; }
        private int SodasAmount { get; set; }

        internal double CalculateBill()
        {
            double total = (this.FrenchFriesAmount * PRICE_FRENCH_FRIES) + (this.HotDogAmount * PRICE_HOT_DOG) + (this.SodasAmount * PRICE_SODA);
            double tip = total * TIP_PRICE;
            return total + tip;
        }


    }
}
