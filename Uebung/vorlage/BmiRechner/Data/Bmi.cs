using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BmiRechner.Data
{
    public class Bmi
    {        
        public double Weight { get; set; }

        public double Height { get; set; }
    }
}
