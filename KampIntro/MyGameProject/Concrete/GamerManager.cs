using MyGameProject.Abstract;
using MyGameProject.Adapters;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Player Added!");
            }
            else
            {
                Console.WriteLine("Registration Failed");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Player Deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Player Updated!");
        }
    }
}
