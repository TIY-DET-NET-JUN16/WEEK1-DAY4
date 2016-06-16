using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_DAY4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle(4, 0);
            car.StartVehicle();
            car.Model = "Ford";

            Vehicle motorcycle = new Vehicle();
            motorcycle.Model = "Honda";
            motorcycle.NumberWheels = 2;

            Person fred = new Person(new DateTime(1950, 5, 16));
            int age = fred.Age;

            Person wilma = new Person(new DateTime(1951, 3, 6));
        }
    }

    public class Vehicle
    {
        public Vehicle()
        {
        }

        public Vehicle(int numberWheels)
        {
            _numberWheels = numberWheels;
        }

        public Vehicle(int numWheels, int numWindows)
        {
            if (numWheels > 0)
                _numberWheels = numWheels;

            if (numWindows > 0)
                _numWindows = numWindows;
        }

        public Vehicle(string model)
        {
            _model = model;
        }

        #region Properties

        private string _model;
        private bool _isRunning;
        private int _numberWheels;
        private int _numWindows;

        #endregion

        #region Methods

        public bool StartVehicle()
        {
            if (this._isRunning)
                return false;
            else
            {
                this._isRunning = true;
                return true;
            }
        }

        public void StopVehicle()
        {
            if (_isRunning)
                _isRunning = false;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int NumberWheels
        {
            set { _numberWheels = value; }
            get { return _numberWheels; }
        }

        #endregion
    }

    public class Person
    {
        public Person(DateTime dob)
        {
            _bd = dob;
        }

        #region Properties

        DateTime _bd;

        #endregion

        #region Methods

        public int Age
        {
            get { return DateTime.Now.Year - _bd.Year; }
        }

        #endregion
    }
}

