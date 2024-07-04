using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Pr_6._1
{
    internal class Client
    {
        public double Money { get; private set; } = 800.96;
        /// <summary>
        /// Метод для того, чтобы узнать хватает ли денег на покупку корма.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public bool MoneyIsNormal(double price)
        {
            if (price > Money)
                return false;
            else return true;
        }
        /// <summary>
        /// Метод для того, чтобы узнать баланс клиента, после покупки.
        /// </summary>
        /// <param name="price"></param>
        public void MoneyRemains(double price)
        {
            Money -= price;
        }
    }
}
