﻿using MyGameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
