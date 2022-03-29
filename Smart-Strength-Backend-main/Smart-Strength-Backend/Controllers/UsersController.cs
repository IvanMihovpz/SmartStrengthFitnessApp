using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smart_Strength_Backend.Models;
using Smart_Strength_Backend.Services;
using Smart_Strength_Backend.Services.Interfaces;

namespace Smart_Strength_Backend.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public IUsersService UsersService { get; }
        public ITrainingsService TrainingsService { get; }

        public UsersController(IUsersService usersService, ITrainingsService trainingsService)
        {
            this.UsersService = usersService;
            this.TrainingsService = trainingsService;
        }
        [HttpPost]
        [Route("create")]
        public async Task<string> CreateUser(string fullName, string fbToken)
        {
            try
            {
                string id = await this.UsersService.CreateUser(fullName, fbToken);
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }

        }

        [HttpGet]
        [Route("getIdfbToken")]
        public async Task<string> GetIdFromToken(string fbToken)
        {
            try
            {
                string id = await this.UsersService.GetIdFromToken(fbToken);
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }

        }

        //[HttpPost]
        //[Route("addTrainingProgram")]
        //public async Task<bool> AddTrainingProgram(string userId, TrainingProgram trainingProgram)
        //{
        //    try
        //    {
        //        DocumentReference user = this.FirestoreDb.Collection("Users").Document(userId);
        //        DocumentSnapshot singleUserSnapShot = await user.GetSnapshotAsync();
        //        if (singleUserSnapShot.Exists)
        //        {
        //            bool result = await this.UsersService.AddTrainingProgramToUser(trainingProgram, userId);
        //            return result;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return false;
        //    }

        //}

    }
}
