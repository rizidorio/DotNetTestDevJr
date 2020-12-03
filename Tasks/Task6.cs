using System;
using System.Collections.Generic;

namespace Tasks
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers) 
        {
            int positive = 0;
            int negatives = 0;
            int zeroes = 0;

            List<decimal> ratios = new List<decimal>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                    positive++;

                if (numbers[i] < 0)
                    negatives++;

                if (numbers[i] == 0)
                    zeroes++;
            }

            string ratiosPositive = (Convert.ToDecimal(positive) / Convert.ToDecimal(numbers.Count)).ToString("0.000000");
            string ratiosNegatives = (Convert.ToDecimal(negatives) / Convert.ToDecimal(numbers.Count)).ToString("0.000000");
            string ratiosZeroes = (Convert.ToDecimal(zeroes) / Convert.ToDecimal(numbers.Count)).ToString("0.000000");

            ratios.Add(decimal.Parse(ratiosPositive));
            ratios.Add(decimal.Parse(ratiosNegatives));
            ratios.Add(decimal.Parse(ratiosZeroes));

            return ratios;
        }
    }
}
