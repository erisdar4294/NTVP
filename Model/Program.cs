using System;
using FuelModele;

namespace FuelModele
{
    class Program
    {
        /// <summary>
        /// точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.RunProgram();
        }

        /// <summary>
        /// метод запуска программы
        /// а именно: меню выборы транспортного средства
        /// </summary>
        private void RunProgram()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите транспортное средство: 1 - машина; 2 - гибрид-кар; 3 - вертолет.");
                    var g = Console.ReadLine();
                    var enteredValue = Convert.ToInt32(g);
                    IFuelable type;
                    switch (enteredValue)
                    {
                        case 1:
                            type = EnterCar();
                            break;
                        case 2:
                            type = EnterHybridCar();
                            break;
                        case 3:
                            type = EnterHelicopter();
                            break;
                        default: throw new Exception();
                    }
                    Console.WriteLine(type.CalcFuel);
                    Console.ReadLine();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный вариант");
                }
            }
        }

        /// <summary>
        /// валидация данных
        /// вводить можно только числа с 0 -9
        /// </summary>
        /// <returns></returns>
        private int WriteNumber()
        {
            while (true)
            {
                try
                {
                    return Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вводить можно только числа");
                }
            }
        }

        /// <summary>
        /// заполнение данных при подсчете расходов при поздке на машине
        /// </summary>
        /// <returns></returns>
        private IFuelable EnterCar()
        {
            Car car = new Car();
            Console.WriteLine("Введите стоимость бензина за литр");
            car.Coastof = WriteNumber();
            Console.WriteLine("Введите расход на 100 км");
            car.Consuption = WriteNumber();
            Console.WriteLine("Введите пройденное расстояние");
            car.Distance = WriteNumber();
            Console.WriteLine("Ваши затраты на поездку составили: " + car.CalcFuel);
            return car;
        }

        /// <summary>
        /// заполнение данных при подсчете расходов при поздке на гибрид машине
        /// </summary>
        /// <returns></returns>
        private IFuelable EnterHybridCar()
        {
            HybridCar hybrid = new HybridCar();
            Console.WriteLine("Введите стоимость заряда батареи");
            hybrid.ChargingCoast = WriteNumber();
            Console.WriteLine("Введите пройденное расстояние");
            hybrid.Distance = WriteNumber();
            Console.WriteLine("Введите расстояние, которое можно проехать на одной батарее");
            hybrid.Time = WriteNumber();
            Console.WriteLine("Ваши затраты на поездку составили: " + hybrid.CalcFuel);
            return hybrid;
        }

        /// <summary>
        /// заполнение данных при подсчете расходов при поздке на вертолете
        /// </summary>
        /// <returns></returns>
        private IFuelable EnterHelicopter()
        {
            Helicopter helicopter = new Helicopter();
            Console.WriteLine("Введите стоимость аренды вертолета");
            helicopter.RentHelicopter = WriteNumber();
            Console.WriteLine("Введите время аренды вертолета");
            helicopter.Time = WriteNumber();
            Console.WriteLine("Вветите стоимость страхования здоровья");
            helicopter.InsuranceLife = WriteNumber();
            Console.WriteLine("Ваши расходы при полете на вертолете" + helicopter.CalcFuel);
            return helicopter;
        }
    }
}
