using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Logan Walsh
//3-2-2023
//This is a threading simulation for a dartboard

namespace CW_9_Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dartInt;
            int threadInt;

            Console.Write("How many darts do you want to throw for each round: ");
            dartInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many rounds do you want to run: ");
            threadInt = Convert.ToInt32(Console.ReadLine());

            List<Thread> roundThread = new List<Thread>();
            List<FindPiThread> piThread = new List<FindPiThread>();

            for(int i = 0; i < threadInt; i++)
            {
                FindPiThread find = new FindPiThread(dartInt);
                piThread.Add(find);
                Thread newPiThread = new Thread(new ThreadStart(find.throwDarts));
                roundThread.Add(newPiThread);
                newPiThread.Start();
                Thread.Sleep(16);
            }
            foreach(var Thread in roundThread)
            {
                Thread.Join();
            }

            double count = 0;
            foreach(var FindPiThread in piThread)
            {
                count += FindPiThread.getScore();
            }

            double averageDenom = dartInt * threadInt;
            double average = (count * 4) / (averageDenom);

            Console.WriteLine("Average Score: " + average);
            Console.ReadKey();
        }
    }
}
