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
        public int Odometer{ get; private set; }
        public double DailyRate { get; private set; }
        public double FuelLvRate { get; private set; }

        public Vehicle(string licensePlate, int id, int odometerKM, double dailyRate, double fuelLvPerc) //{l'unico metodo che non dobbiamo definire metodo di ritorno}
        {
            LicensePlate = licensePlate; //set
        } 
    }
}