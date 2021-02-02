using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        Gamer _gamer;

        public GameSaleManager(Gamer gamer)
        {
            _gamer = gamer;
        }

        public void Sale(Game game)
        {
            Console.WriteLine(game.GameId);
            Console.WriteLine(game.GameName);
            Console.WriteLine(game.GamePrice);

            Console.WriteLine(" ");

            Console.WriteLine(game.GameName+" "+"Oyun Başarıyla Satıldı");

            Console.WriteLine(" ");

            Console.WriteLine("Alıcı Özellikleri:");
            Console.WriteLine("Alıcı ID'si :" + " " + _gamer.Id);
            Console.WriteLine("Alıcı İsmi :"+" "+_gamer.FirstName);
            Console.WriteLine("Alıcı Soyismi :" + " " + _gamer.LastName);
            Console.WriteLine("Alıcı Doğum Tarihi :" + " " + _gamer.DateOfBirth);

            Console.WriteLine(" ");

            Console.WriteLine("Oyun Özellikleri:");
            Console.WriteLine("Oyun Fiyatı :" + " " + game.GamePrice);
            Console.WriteLine("Oyun ID'si :"+" "+game.GameId);
        }
    }
}
