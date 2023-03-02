using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Logan Walsh
//3-2-2023
//This is a threading simulation for a dartboard

namespace CW_9_Threading
{
    public class FindPiThread
    {
        int dartsThrow;
        int dartsCount;
        Random rand;
        FindPiThread(int dThrow)
        {
            rand = new Random();
            int dartsThrow = dThrow;

        }
        public void throwDarts()
        {
            
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
