using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Task2
{
    public class NFL_player
    {
        //Private field

        private double purpose_yrds;

        //Public properties

        public string Player_name
        {
            get;
        }

        public string Franchise
        {
            get;
        }

        public double Purp_Yrds
        {
            get
            {
                return purpose_yrds;
            }
        }

        //Constructor

        public NFL_player(string new_player_name, string new_franchise, double rush_yards, double pass_yards)
        {
            if (string.IsNullOrWhiteSpace(new_player_name)) throw new ArgumentException("Playername must not be empty.", nameof(new_player_name));
            if (string.IsNullOrWhiteSpace(new_franchise)) throw new ArgumentException("Franchise must not be empty.", nameof(new_franchise));

            Player_name = new_player_name;
            Franchise = new_franchise;

            Calc_Purp(rush_yards, pass_yards);

        }

        //Public method
        public void Calc_Purp(double new_rush_yards, double new_pass_yards)
        {
            purpose_yrds = new_rush_yards + new_pass_yards;

        }

    }

}

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create objects
            NFL_player a = new NFL_player("David Johnson", "Arizona Cardinals", 1150, 560);
            NFL_player b = new NFL_player("LeVeon Bell", "Pittsburgh Steelers", 1042, 1003);

            //Print properties
            Console.WriteLine(a.Player_name);
            Console.WriteLine(a.Franchise);
            Console.WriteLine(a.Purp_Yrds);
            Console.WriteLine(b.Player_name);
            Console.WriteLine(b.Franchise);
            Console.WriteLine(b.Purp_Yrds);

            //Call method and print effect to console
            a.Calc_Purp(100, 200);
            Console.WriteLine(a.Player_name);
            Console.WriteLine(a.Franchise);
            Console.WriteLine(a.Purp_Yrds);

        }
    }
}
