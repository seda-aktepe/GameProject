using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    class UserValidationManager : IUserValidationService
    {
        //public bool Validate(Gamer gamer)
        //{
        //    if (gamer.DateOfBirth == 1997 && gamer.FirstName == "SEDA" && gamer.LastName == "AKTEPE" && gamer.Tc == 134567)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
