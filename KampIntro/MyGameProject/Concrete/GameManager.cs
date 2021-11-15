using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Added!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game Deleted!");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game Updated!");
        }
    }
}
