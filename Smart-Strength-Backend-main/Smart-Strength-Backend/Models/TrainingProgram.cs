using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Strength_Backend.Models
{
    public class TrainingProgram
    {
        public string Name { get; set; }
        public Workout[] Workouts { get; set; }

    }
}
