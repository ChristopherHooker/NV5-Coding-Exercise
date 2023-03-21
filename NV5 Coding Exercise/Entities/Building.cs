using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV5_Coding_Exercise.Entities
{
    internal class Building
    {
        int Rank { get; set; }
        string? Name { get; set; }
        double Coordinate_X { get; set; }
        double Coordinate_Y { get; set; }
        double Elevation { get; set; }
        int Height { get; set; }
        int Floors { get; set; }
        int Year { get; set; }
        string? Notes { get; set; }

    }
}
