using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Rekendemo.Classes
{
    internal class oSom
    {

        private Random rnd = new Random();
        public oSom()
        {
            // Constructor
            getal1 = GenerateRandomNumber();
            getal2 = GenerateRandomNumber();
        }

        // create a randomizer

        // create a method to generate a random number between 1 and 10
        public int GenerateRandomNumber()
        {
            int intRandomNumber = rnd.Next(1, 11);
            return intRandomNumber;
        }

        public int getal1 { get; set; }
        public int getal2 { get; set; }
    }
}
