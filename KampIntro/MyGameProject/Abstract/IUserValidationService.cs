using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
