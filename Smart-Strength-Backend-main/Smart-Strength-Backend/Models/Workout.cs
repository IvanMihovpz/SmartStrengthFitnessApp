using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Strength_Backend.Models
{
    public class Workout
    {
        public int Difficulty { get; set; }
        public string Day { get; set; }
        public Excercise[] Excercises { get; set; }
    }
}
