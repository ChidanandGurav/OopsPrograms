using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    public class IEnumerableAndIENumerator
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            foreach(Player Item in team)
            {
                Console.WriteLine(Item);
            }
        }
    }

    public class Player
    {
        private int Runs;
        private string Name;

        public Player(int Runs, string Name)
        {
            this.Runs = Runs;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $" {Name} --> {Runs}";
        }
    }

    public class Team:IEnumerable
    {
        private Player[] players;
        public Team()
        {
            players = new Player[3]
            {
                new Player(5000 , "Sachin"),
                new Player(4000 , "Virat"),
                new Player(3500 , "Shikhar")
            };
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
}
