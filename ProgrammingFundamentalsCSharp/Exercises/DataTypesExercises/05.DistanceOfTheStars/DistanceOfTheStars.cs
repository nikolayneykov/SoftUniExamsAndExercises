using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DistanceOfTheStars
{
    class DistanceOfTheStars
    {
        static void Main(string[] args)
        {
            decimal earthToProximiaCentauri = 9450000000000m * 4.22m;
            decimal centerOfGalaxyToMilkyWay = 9450000000000m * 26000m;
            decimal diamtererOfMilkyWay = 9450000000000m * 100000m;
            decimal earthToTheEdgeOfTheUniverse = 9450000000000m * 46500000000m;
            Console.WriteLine($"{earthToProximiaCentauri:e2}");
            Console.WriteLine($"{centerOfGalaxyToMilkyWay:e2}");
            Console.WriteLine($"{diamtererOfMilkyWay:e2}");
            Console.WriteLine($"{earthToTheEdgeOfTheUniverse:e2}");
        }
    }
}
