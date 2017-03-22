using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelModele
{
    [Serializable]
    public class Helicopter : IFuelable
    {

        /// <summary>
        /// класс вертолет
        /// </summary>     
        public Helicopter()
        {
        }

        /// <summary>
        /// стоимость аренды вертолета
        /// </summary>
        public double RentHelicopter
        {
            get;
            set;
        }

        /// <summary>
        /// стоимость страховки 
        /// вдруг, летя на вертолете клиент травмируется
        /// </summary>
        public double InsuranceLife
        {
            get;
            set;
        }

        /// <summary>
        /// время, на которое арендовали вертолет
        /// </summary>
        public double Time
        {
            get;
            set;
        }

        /// <summary>
        /// подсчет расходов, летя на самолете
        /// </summary>
        public double CalcFuel
        {
            get
            {

                return  Math.Round(RentHelicopter * Time + InsuranceLife,2);
            }
        }
    }
}
