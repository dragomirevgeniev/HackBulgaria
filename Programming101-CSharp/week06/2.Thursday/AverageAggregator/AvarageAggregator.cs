using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAggregator
{
    public delegate void AvarageChanger(object sender, decimal oldAvarage, decimal newAvarage);
    
    public class AverageAggregator
    {
        public decimal Average { get { return average; } }
        public static event AvarageChanger AverageChanged;
        private decimal average;
        private decimal sum;
        private int numbersCount;

        public AverageAggregator(AvarageChanger change)
        {
            sum = 0;
            numbersCount = 0;
            AverageChanged += change;
        }

        public void AddNumber(int number)
        {
            decimal lastAverage = average;
            sum += number;
            average = sum / ++numbersCount;

            if (lastAverage != average)
            {
                AverageChanged(this, lastAverage, average);
            }
        }
    }
}
