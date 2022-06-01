using System;
using System.Collections.Generic;

namespace ChessTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tournament = new Tournament<Adult, Junior>();
            var tourn2 = new Tournament<Adult, Kid>();

            var newtourn = new AbstractTourn<Tournament<Adult, Junior>>();
            var newtourn2 = new AbstractTourn<Tournament3<Adult>>();
        }

        class Player<T>
        {
            public T PlayerA { get; set; }
            public List<Game<T>> PlayerGames { get; set; }
            public Player()
            {
                if (PlayerA.GetType() == typeof(Adult))
                {

                }
                else if (PlayerA.GetType() == typeof(Junior))
                {

                }
            }
        }


        class Adult
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsDisqualified { get; set; }
        }

        class Junior
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Kid
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Game<T>
        {
            public int Id { get; set; }
            public T Player1 { get; set; }
            public T Player2 { get; set; }
        }


        class Tournament<TAdult, TJunior>
        {
            public int Id { get; set; }
            public List<Game<TAdult>> GamesA { get; set; }
            public List<Game<TJunior>> GamesJ { get; set; }

            //public List<T> Players { get; set; }
        }

        class Tournament2<TAdult, TKid> 
        {
            public int Id { get; set; }
            public List<Game<TAdult>> GamesA { get; set; }
            public List<Game<TKid>> GamesJ { get; set; }

            //public List<T> Players { get; set; }
        }

        class Tournament3<TAdult>
        {
            public int Id { get; set; }
            public List<Game<TAdult>> GamesA { get; set; }

            //public List<T> Players { get; set; }
        }

        class AbstractTourn<TournamentType>
        {

        }

        
    }
}
