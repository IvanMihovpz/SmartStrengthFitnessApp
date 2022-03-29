using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smart_Strength_Backend.Models;
using Smart_Strength_Backend.Services;
using Smart_Strength_Backend.Services.Interfaces;

namespace Smart_Strength_Backend.Controllers
{
    [Route("api/diets")]
    [ApiController]
    public class DietsController : ControllerBase
    {
        public IDietsService DietsService { get; private set; }
        public DietsController(IDietsService dietsService)
        {
            this.DietsService = dietsService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<Diet> CreateDiet(string userId, string gender, double weight, int height, int fitnessGoal, int age, string progressionRate) 
        {
            try
            {
                Diet diet = this.DietsService.CreateDiet(gender, weight, height, fitnessGoal, age, progressionRate);
                await this.DietsService.AddDietToUser(diet, userId, gender, weight, height, age);
                return diet;
            }
            catch(Exception ex)
            {
                return new Diet()
                {
                    Goal = "Build muscle",
                    Calories = 2600,
                    Carbs = 240,
                    Fat = 50,
                    Protein = 50,
                };

            }
        }

    }
}
