using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV5_Coding_Exercise.Entities
{
    public class Location
    {
        public string? Name { get; set; }
        public double Coordinate_X { get; set; }
        public double Coordinate_Y { get; set; }
        public double Elevation { get; set; }

        /// <summary>
        /// Gets the distance from this Location to another one.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public double calculateDistance(Location target)
        {
            double xDistance = Math.Abs(target.Coordinate_X - Coordinate_X);
            double yDistance = Math.Abs(target.Coordinate_Y - Coordinate_Y);

            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        }
    }
}
