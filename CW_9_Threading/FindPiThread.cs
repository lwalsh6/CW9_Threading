using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_9_Threading
{
    public class FindPiThread
    {
        int dartsThrow;
        int dartsCount;
        Random rand;
        public FindPiThread(int dThrow)
        {
            rand = new Random();
            int dartsThrow = dThrow;
            dartsCount = 0;
            Console.WriteLine(dThrow);
            Console.WriteLine(dartsThrow);
        }
        public int getScore()
        {
            return dartsCount;
        }
        public void throwDarts()
        {

            double y;
            double x;

            for (int i = 1; i <= dartsThrow; i++)
            {
                y = rand.NextDouble();
                x = rand.NextDouble();
                double points = Math.Sqrt((x * x) + (y * y));
                if (points < 1)
                {
                    dartsCount++;
                }
            }
        }
    }
}
