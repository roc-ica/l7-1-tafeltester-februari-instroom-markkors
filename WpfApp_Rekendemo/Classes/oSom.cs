using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Rekendemo.Classes
{
    internal class oSom
    {

        private Random rnd;
        public enum eOperators
        {
            add,
            subtract,
            divide,
            multiply
        }

        

        
        public oSom(Random r)
        {
            // Constructor
            rnd = r;
            getal1 = GenerateRandomNumber();
            getal2 = GenerateRandomNumber();
            int iOperator = GenerateRandomOperator();
            Operator = (eOperators)iOperator;


        }

        // create a randomizer

        // create a method to generate a random number between 1 and 10
        private int GenerateRandomNumber()
        {
            int intRandomNumber = rnd.Next(1, 11);
            return intRandomNumber;
        }

        private int GenerateRandomOperator()
        {
            int intRandomOperator = rnd.Next(0, 4);
            
            return intRandomOperator;
        }

        public int getResult()
        {
            
            int r = 0;

            switch(Operator)
            {
                case eOperators.add:
                    r = getal1 + getal2;
                    break;

                case eOperators.subtract:
                    r = getal1 - getal2;
                    break;

                case eOperators.divide:
                    r = getal1 / getal2;
                    break;

                case eOperators.multiply:
                    r = getal1 * getal2;
                    break;
                


            }
            return r;
        }
       

        public int getal1 { get; set; }
        public int getal2 { get; set; }

        public eOperators Operator { get; set; }
        
    }
}
