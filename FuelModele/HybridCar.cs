using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelModele
{
    [Serializable]
    public class HybridCar : IFuelable
    {
        /// <summary>
        /// класс гибридная машина
        /// </summary>
        public HybridCar()
        {
        }

        /// <summary>
        /// стоимость одной зарядки батареи
        /// </summary>
        public double ChargingCoast
        {
            get;
            set;
        }

        /// <summary>
        /// расстояние
        /// </summary>
        public double Distance
        {
            get;
            set;
        }

        /// <summary>
        /// расстояние, которое можно проехать на одной заряженной батарее
        /// </summary>
        public double Time
        {
            get;
            set;
        }

        /// <summary>
        /// подсчет расходов при поездке на гибридно машине
        /// </summary>
        public double CalcFuel
        {
            get
            {
                return Math.Round(Distance / Time * ChargingCoast,2);
            }
        }
    }
}
