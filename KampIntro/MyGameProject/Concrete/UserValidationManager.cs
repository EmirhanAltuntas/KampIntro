using MyGameProject.Abstract;
using MyGameProject.Adapters;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            IUserValidationService _userValidationService;

            _userValidationService = new MernisServiceAdapter();
            return _userValidationService.Validate(gamer);
        }
    }
}
