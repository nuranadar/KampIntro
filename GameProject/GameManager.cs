using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        List<Game> gameList = new List<Game>();
        

        public void Add(Game game)
        {
            gameList.Add(game);
            Console.WriteLine(game.Name + "has been added to our library.");
        }

        public void List()
        {
            foreach (var game in gameList)
            {
                Console.WriteLine("Game Name" + "\t \t \t" + "Price");
                Console.WriteLine(game.Name + "\t \t" + game.Price);
            }
        }

        public void Remove(Game game)
        {
            gameList.Remove(game);
            Console.WriteLine(game.Name + " has been removed from our library");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " has been updated.");
        }
    }
}
