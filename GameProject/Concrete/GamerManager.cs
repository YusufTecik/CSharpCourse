using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        ICheckService _checkService;

        public GamerManager(ICheckService checkService)
        {

            _checkService = checkService;
        }

        public void Add(Gamer gamer)
        {
            if (_checkService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName +" "+gamer.LastName+" "+"Kayıt Oldu!");
            }

        }

        public void Delete(Gamer gamer)
        {
            if (_checkService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " "+ "Kayıt Silindi!");
            }
        }

        public void Upgrade(Gamer gamer)
        {
            if (_checkService.Check(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " +"Kayıt Güncellendi!");
            }
        }
    }
}
