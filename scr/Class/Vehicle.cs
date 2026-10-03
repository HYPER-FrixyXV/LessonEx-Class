using System; //using=import
using System.Collections.Generic;
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
        private string _licensePlate;
        private int _odometerKm;
        private double _rent;
        private double _fuelLvPerc;


    }
}
