using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelModele
{

    [Serializable]
    public class Car : IFuelable
    {

        /// <summary>
        /// класс машина
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// цена бензина за 1 литр
        /// </summary>
        public double Coastof
        {
            get;
            set;
        }

        /// <summary>
        /// расстояние, на которое совершается путешествие
        /// </summary>
        public double Distance
        {
            get;
            set;
        }

        /// <summary>
        /// расход бензина на 100 км
        /// </summary>
        public double Consuption
        {
            get;
            set;
        }
        
        /// <summary>
        /// подсчет расходов при езде на машине
        /// </summary>
        public double CalcFuel
        {
            get
            {
                return (Consuption / 100) * Distance * Coastof;
            }
        }
    }
}
