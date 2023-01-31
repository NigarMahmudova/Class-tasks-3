using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Drink:Product
    {
        private double _alcoholPercent;

        public double AlcoholPercent
        {
            set
            {
                if (value >=0 && value <= 100)
                {
                    _alcoholPercent = value;
                }
            }
            get
            {
                return _alcoholPercent;
            }
        }

    }
}
