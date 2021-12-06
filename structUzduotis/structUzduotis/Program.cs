using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public struct Pazymiai
        {
            public int PirmasTrimestras;
            public int AntrasTrimestras;
            public int TreciasTrimestras;

            public Pazymiai(int pirmasTrimestras, int antrasTrimestas, int treciasTrimestras)
            {
                PirmasTrimestras = pirmasTrimestras;
                AntrasTrimestras = antrasTrimestas;
                TreciasTrimestras = treciasTrimestras;
            }

            public int vidurkis()
            {
                int vidurkis = (PirmasTrimestras + AntrasTrimestras + TreciasTrimestras) / 3;
                return vidurkis;
            }
        }

        public static void Main(string[] args)
        {
            Pazymiai pazymiai = new Pazymiai(8,9,10);
            Console.WriteLine(pazymiai.vidurkis());

        }
    }
}