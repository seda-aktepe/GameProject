using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrate
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız.");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu silindi.");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu güncellendi.");
        }
    }
}
