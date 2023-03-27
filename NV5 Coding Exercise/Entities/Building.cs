using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NV5_Coding_Exercise.Entities
{
    /// <summary>
    /// Object to represent Building Data.
    /// </summary>
    public class Building : Location
    {
        public double Rank { get; set; }
        public double Height { get; set; }
        public double Floors { get; set; }
        public double Year { get; set; }
        public string? Notes { get; set; }
    }
}
