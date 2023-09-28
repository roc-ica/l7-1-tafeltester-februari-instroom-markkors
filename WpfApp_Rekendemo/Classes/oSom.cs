using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace WpfApp_Rekendemo.Classes
{
    public class oSom
    {

        private Random rnd;
        public enum eOperators
        {
            add,
            subtract,
            multiply,
            divide

        }


        public enum eDifficulty
        {
            easy,
            medium,
            hard
        }

        /// <summary>
        /// Een som object bestaat uit 2 getallen en een operator
        /// </summary>
        /// <param name="r">Randomizer object</param>              
        public oSom(Random r,eDifficulty difficulty)
        {

           


            // Constructor
            Difficulty = difficulty;
            rnd = r;
            int iOperator = GenerateRandomOperator();
            Operator = (eOperators)iOperator;
            getal1 = GenerateRandomNumber();
            getal2 = GenerateRandomNumber();
            
            Result = createResult().ToString();
            // explicite cast
            
       }

        
        // method to generate random numbers
        private int GenerateRandomNumber()
        {
            switch (Difficulty)
            {
                case eDifficulty.easy:
                    return rnd.Next(1, 10);
                case eDifficulty.medium:
                    return rnd.Next(1, 100);
                case eDifficulty.hard:
                    if (Operator==eOperators.divide)
                    {
                        // bij moeilijke sommen doet de deling mee,
                        // maak het tweede getal dan een random veelvoud van het eerste getal
                        return GenerateRandomMultipleNumber(1, 1000);
                    }
                    else
                    {
                        // bij moeilijk keersommen iets minder grotere getallen
                        if(Operator==eOperators.multiply)
                        {
                            return rnd.Next(1, 100);
                        } else
                        {
                            // bij moeilijke optel en aftreksommen iets grotere getallen
                            return rnd.Next(1, 1000);
                        }
                        
                    }
                default:
                    return rnd.Next(1, 10);
            }   
        }

        private int GenerateRandomMultipleNumber(int min, int max)
        {
            int n;
            do
            {
                n = rnd.Next(min, max);
            } while (getal1 % n != 0); // // Blijf genereren totdat het tweede getal een veelvoud is van het eerste
            
            return n;
        }

        private int GenerateRandomOperator()
        {
            switch (Difficulty)
            {
                case eDifficulty.easy:
                    return rnd.Next(0, 2);
                case eDifficulty.medium:
                    return rnd.Next(0, 3);
                case eDifficulty.hard:
                    return rnd.Next(0, 4);
                default:
                    return rnd.Next(0, 2);
            }
           
        }

        public float createResult()
        {
            // nullable int type to return the result
            float r = 0;

            switch(Operator)
            {
                case eOperators.add:
                    r = getal1 + getal2;
                    break;

                case eOperators.subtract:
                    r = getal1 - getal2;
                    break;

                case eOperators.divide:
                    r = (float)getal1 / getal2;
                    break;

                case eOperators.multiply:
                    r = getal1 * getal2;
                    break;
            }
            return r;
        }

        #region "Properties"

        public int getal1 { get; set; }
        public int getal2 { get; set; }
        public string Result { get; set; }
        public eOperators Operator { get; set; }
        public eDifficulty Difficulty { get; set; }

        public string SumAsText { 
            get {
                string OperatorSign=null;
                // make the operator the correct symbol
                switch (Operator)
                {
                    
                    case eOperators.add:
                        OperatorSign = "+";
                        break;
                    case eOperators.subtract:
                        OperatorSign = "-";
                        break;
                    case eOperators.divide:
                        OperatorSign = "/";
                        break;
                    case eOperators.multiply:
                        OperatorSign = "*";
                        break;
                }
                return $"{getal1.ToString()} {OperatorSign.ToString()} {getal2.ToString()}"; } 
        } 

        public string SumAsTextWithResult
        {
            get
            {
                return SumAsText + " = " + Result;
            }
        }   

        #endregion
    }
}
