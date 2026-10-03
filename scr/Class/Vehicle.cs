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
        private double _rent;
        private double _fuelLvPerc;
        public string LicensePlate { get; private set; } //get è pubblico e set è privato

        public Vehicle(string licensePlate) //{l'unico metodo che non dobbiamo definire metodo di ritorno}
        {
            LicensePlate = licensePlate; //set
        } 
    }
}