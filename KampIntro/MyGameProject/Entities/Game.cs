using MyGameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
}
