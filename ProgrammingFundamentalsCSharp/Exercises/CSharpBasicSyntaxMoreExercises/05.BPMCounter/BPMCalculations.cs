using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class BPMCalculations
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());
            double bars = Math.Round((numberOfBeats / 4.0), 1);
            double seconds = Math.Floor((numberOfBeats / beatsPerMinute) * 60);
            double minutes =(int)seconds / 60;
            seconds %= 60;
            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
