using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_8
{
    class Car:Vehicle
    {
        public Car(double fuelCapacity)
        {
            _currentFuel = fuelCapacity;
        }
        private double _fuelCapacity;
        public double FuelCapacity
        {
            set
            {
                if (_currentFuel <= value)
                {
                    _fuelCapacity = value;
                } 
            }
            get => _fuelCapacity;
        }

        private double _currentFuel;
        public double CurrentFuel => _currentFuel;
        public double FuelFor1Km;

        public void AddFuel(double fuel)
        {
            double newFuel = _currentFuel + fuel;
            if (newFuel <= _fuelCapacity)
            {
                _fuelCapacity += fuel;
            }
        }

        public override void Drive(double km)
        {
            double neededFuel = km * FuelFor1Km;

            if (_currentFuel >= neededFuel)
            {
                _currentFuel -= neededFuel;
                Drive(km);
            }
        }
    }
}
