using System; //using=import
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BPascal.LessonEx2.ClassDomain
{
    /*la classe vehicle deve avere (attributi/proprietà):
    -id
    -targa
    -km attuale
    -tariffa noleggio
    -livello attuale carburante

    devo poter (function/metodi):
    -aggiornare dati
    -rifornimento (aumento di una certa %)
    */
    public class Vehicle
    {
        private int _id;
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLvPerc;

        public string LicensePlate { get; private set; }
        public int ID { get; private set; }
        public int Odometer
        {
            get { return _odometerKm; }
            private set 
            {
                if(value < 0) {
                    throw new ArgumentException("Odometer value cannot be negative.");
                }
            }
        }
        public double DailyRate
        {
            get { return _dailyRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Daily rate value cannot be negative.");
                }
            }
        }
        public double FuelLvPerc
        {
            get { return _fuelLvPerc; }
            private set
            {
                if (value < 0 || value >100)
                {
                    throw new ArgumentException("Fuel level percentage value cannot be negative.");
                }
            }
        }

        public Vehicle(string licensePlate, int id, int odometerKM, double dailyRate, double fuelLvPerc) //{l'unico metodo che non dobbiamo definire metodo di ritorno}
        {
            LicensePlate = licensePlate; //set
            ID = id;
            Odometer = odometerKM;
            DailyRate = dailyRate ;
            FuelLvPerc = fuelLvPerc ;
        }
    }
}