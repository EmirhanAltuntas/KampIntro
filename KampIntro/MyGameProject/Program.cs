using System;
using MyGameProject.Abstract;
using MyGameProject.Adapters;
using MyGameProject.Concrete;
using MyGameProject.Entities;
using System.Collections.Generic;
namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            { 
                Id=1,
                NationalityId=123456,
                DateOfBirth= new DateTime(1999),
                UserName = "Legolas",
                FirstName = "Eren",
                LastName = "Çam"
            };
            Gamer gamer2 = new Gamer
            {
                Id = 2,
                NationalityId = 1234567,
                DateOfBirth = new DateTime(1999),
                UserName = "Dark",
                FirstName = "Can",
                LastName = "Kan"
            };
            Game game = new Game
            {
                Id=1,
                GameName="Metin2",
                Category= "MMORPG",
                Price = 0
            };
            Campaign campaign = new Campaign
            {
                Id=1,
                CampaignName="Büyük İndirim",
                DiscountRate= 0.15m
            };
            
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
        }
    }
}
