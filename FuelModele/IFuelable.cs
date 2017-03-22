using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelModele
{

    /// <summary>
    /// интерфейс с методом подсчета расходов
    /// </summary>
    public interface IFuelable
    {

        double CalcFuel { get; }
    }
}
