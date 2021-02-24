using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Id + " isimli oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Id + " isimli oyun silidi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Id + " isimli oyun güncellendi.");
        }
    }
}
