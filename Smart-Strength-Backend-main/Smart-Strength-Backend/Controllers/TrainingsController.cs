using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smart_Strength_Backend.Models;
using Smart_Strength_Backend.Services;
using Smart_Strength_Backend.Services.Interfaces;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Smart_Strength_Backend.Controllers
{
    [ApiController]
    [Route("api/trainings")]
    public class TrainingsController : ControllerBase
    {
        public IUsersService UsersService { get; }
        public ITrainingsService TrainingsService { get; }

        public TrainingsController(IUsersService usersService, ITrainingsService trainingsService)
        {
            this.UsersService = usersService;
            this.TrainingsService = trainingsService;
        }


        [HttpPost]
        [Route("create")]
        public async Task<TrainingProgram> CreateTrainingRegime(string userId, string fitnessGoal, string progressionRate, string trainingDuration, string trainingExperience, string workoutPreference, string workoutsPerWeek )
        {
            try
            {
                IExcercisesRepo excercisesRepo = new ExcercisesRepo();
                excercisesRepo.Init(progressionRate, trainingExperience, fitnessGoal);
                IWorkoutsService workoutsService = new WorkoutsService(excercisesRepo);
                Workout[] workouts = workoutsService.CreateWorkouts(fitnessGoal, trainingExperience, workoutsPerWeek);
                TrainingProgram trainingProgram = new TrainingProgram();

                trainingProgram.Workouts = workouts;
                trainingProgram.Name = CreateRegimeName(trainingExperience, fitnessGoal);
                await this.UsersService.AddTrainingProgramToUser(trainingProgram, userId);
                return trainingProgram;

            }
            catch (Exception ex)
            {
                return new TrainingProgram()
                {
                    Name = "Push/Pull/Legs with slow reps",
                    Workouts = new Workout[]
                    {
                        new Workout()
                        {
                            Difficulty = 1,
                            Excercises = new Excercise[]
                            {
                                new Excercise()
                                {
                                    Name = "Bench press",
                                    Reps = 8,
                                    Sets = 4,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Dumbell shoulder press",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Incline dumbell press",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Lateral raises",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Cable crossover",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Dips",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "normal"
                                },
                                new Excercise()
                                {
                                    Name = "Triceps Pushdown",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "normal"
                                },
                            }
                        },
                        new Workout()
                        {
                            Difficulty = 1,
                            Excercises = new Excercise[]
                            {
                                new Excercise()
                                {
                                    Name = "Pull ups",
                                    Reps = 8,
                                    Sets = 4,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Seated cable rows",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Pulldown",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Face pulls",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Ez bar curls",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Hammer curls",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "normal"
                                },
                            }
                        },
                        new Workout()
                        {
                            Difficulty = 1,
                            Excercises = new Excercise[]
                            {
                                new Excercise()
                                {
                                    Name = "Squats",
                                    Reps = 8,
                                    Sets = 4,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Romanian deadlift",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Leg press",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Leg extensions",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Calf raises",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                            }
                        },
                        new Workout()
                        {
                            Difficulty = 1,
                            Excercises = new Excercise[]
                            {
                                new Excercise()
                                {
                                    Name = "Bench press",
                                    Reps = 8,
                                    Sets = 4,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Dumbell shoulder press",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Incline dumbell press",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Lateral raises",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Cable crossover",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Dips",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "normal"
                                },
                                new Excercise()
                                {
                                    Name = "Triceps Pushdown",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "normal"
                                },
                            }
                        },
                        new Workout()
                        {
                            Difficulty = 1,
                            Excercises = new Excercise[]
                            {
                                new Excercise()
                                {
                                    Name = "Pull ups",
                                    Reps = 8,
                                    Sets = 4,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Seated cable rows",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Pulldown",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Face pulls",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Ez bar curls",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Hammer curls",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "normal"
                                },
                            }
                        },
                        new Workout()
                        {
                            Difficulty = 1,
                            Excercises = new Excercise[]
                            {
                                new Excercise()
                                {
                                    Name = "Squats",
                                    Reps = 8,
                                    Sets = 4,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Romanian deadlift",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Leg press",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Leg extensions",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                                new Excercise()
                                {
                                    Name = "Calf raises",
                                    Reps = 10,
                                    Sets = 3,
                                    Tempo = "slow"
                                },
                            }
                        },
                    }
                };
            }
        }

        [HttpGet]
        [Route("get")]
        public async Task<Workout> GetTodaysWorkout(string userId)
        {
            try
            {
                if (String.IsNullOrEmpty(userId))
                {
                    return null;
                }

                Workout workout = await this.TrainingsService.GetWorkout(userId);

                return workout;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        [HttpPost]
        [Route("save")]
        public async Task<bool> SaveWorkout([FromBody] Dictionary<string, string> workout)
        {
            try
            {
                if (String.IsNullOrEmpty(null))
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        private string CreateRegimeName(string trainingExperience, string fitnessGoal)
        {
            switch (fitnessGoal)
            {
                case "1":
                    switch (trainingExperience)
                    {
                        case "1":
                            return "Full body with fast tempo";
                        case "2":
                            return "Push/Pull/Legs with fast tempo";
                        case "3":
                            return "Push/Pull/Legs with fast tempo";
                        default:
                            return "Upper/Lower split";
                    }
                case "2":
                    switch (trainingExperience)
                    {
                        case "1":
                            return "Full body with normal tempo";
                        case "2":
                            return "Push/Pull/Legs with normal tempo";
                        case "3":
                            return "Push/Pull/Legs with normal tempo";
                        default:
                            return "Upper/Lower split";
                    }
                case "3":
                    switch (trainingExperience)
                    {
                        case "1":
                            return "Full body with normal tempo";

                        case "2":
                            return "Push/Pull/Legs with normal tempo";

                        case "3":
                            return "Push/Pull/Legs with normal tempo";
                        default:
                            return "Upper/Lower split";
                    }
                case "4":
                    switch (trainingExperience)
                    {
                        case "1":
                            return "Full body with slow reps";

                        case "2":
                            return "Push/Pull/Legs with slow tempo";

                        case "3":
                            return "Push/Pull/Legs with slow tempo";
                        default:
                            return "Upper/Lower split";
                    }
                default:
                    break;

            }
            return null;

        }
    }
}
