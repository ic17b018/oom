using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface INFL_player
    {
        void Print();
    }

    //Class - Runningback
    public class RunningBack : INFL_player
    {
        public void Print()
        {
            Console.WriteLine($"NFL-Player-RB --> {Rb_name}\nNFL-Team --> {Rb_franchise}\nPurpose-Yards --> {Rb_purp_yrds}");
        }
        //Private field

        private double purpose_yrds;

        //Public properties

        public string Rb_name
        {
            get;
        }

        public string Rb_franchise
        {
            get;
        }

        public double Rb_purp_yrds
        {
            get
            {
                return purpose_yrds;
            }
        }

        public RunningBack(string new_player_name, string new_franchise, double rush_yards, double pass_yards, double ret_yards)
        {
            if (string.IsNullOrWhiteSpace(new_player_name)) throw new ArgumentException("Playername must not be empty.", nameof(new_player_name));
            if (string.IsNullOrWhiteSpace(new_franchise)) throw new ArgumentException("Franchise must not be empty.", nameof(new_franchise));

            Rb_name = new_player_name;
            Rb_franchise = new_franchise;

            Calc_Purp(rush_yards, pass_yards, ret_yards);

        }
        //Public method Rb
        public void Calc_Purp(double new_rush_yards, double new_pass_yards, double new_return_yards)
        {
            purpose_yrds = new_rush_yards + new_pass_yards + new_return_yards;
        }
    }

        // Class - Quarterback

        public class QuarterBack : INFL_player
        {
            public void Print()
            {
                Console.WriteLine($"NFL-Player-QB --> {Qb_name}\nNFL-Team --> {Qb_franchise}\nPurpose-Yards --> {Qb_purp_yrds}");
            }
            //Private field

            private double purpose_yrds;

            //Public properties

            public string Qb_name
            {
                get;
            }

            public string Qb_franchise
            {
                get;
            }

            public double Qb_purp_yrds
            {
                get
                {
                    return purpose_yrds;
                }
            }

            //Constructor QB

            public QuarterBack(string new_player_name, string new_franchise, double rush_yards, double pass_yards)
        {
            if (string.IsNullOrWhiteSpace(new_player_name)) throw new ArgumentException("Playername must not be empty.", nameof(new_player_name));
            if (string.IsNullOrWhiteSpace(new_franchise)) throw new ArgumentException("Franchise must not be empty.", nameof(new_franchise));

            Qb_name = new_player_name;
            Qb_franchise = new_franchise;

            Calc_Purp2(rush_yards, pass_yards);

        }
             

        //Public method Qb
         public void Calc_Purp2(double new_rush_yards, double new_pass_yards)
        {
            purpose_yrds = new_rush_yards + new_pass_yards;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        
            //Create objects
            RunningBack a = new RunningBack("David Johnson", "Arizona Cardinals", 1150, 560, 0);
            RunningBack b = new RunningBack("LeVeon Bell", "Pittsburgh Steelers", 1042, 1003, 200);
            QuarterBack c = new QuarterBack("Drew Brees", "New Orleans Saints", 250, 4200);
            QuarterBack d = new QuarterBack("Cam Newton", "Carolina Panthers", 1200, 3758);
                
                //Print Properties
                Console.WriteLine(a.Rb_name);
                Console.WriteLine(a.Rb_franchise);
                Console.WriteLine(a.Rb_purp_yrds);
                Console.WriteLine(b.Rb_name);
                Console.WriteLine(b.Rb_franchise);
                Console.WriteLine(b.Rb_purp_yrds);
                Console.WriteLine(c.Qb_name);
                Console.WriteLine(c.Qb_franchise);
                Console.WriteLine(c.Qb_purp_yrds);
                Console.WriteLine(d.Qb_name);
                Console.WriteLine(d.Qb_franchise);
                Console.WriteLine(d.Qb_purp_yrds);


                INFL_player[] players = {a, b, c, d,  new QuarterBack("Archie Manning", "New Orleans Saints", 0, 0), new RunningBack("Carlos Hyde", "Cleveland Browns", 960, 50, 0)};

                foreach(INFL_player NFL_player in players)
                {
                    NFL_player.Print();
                }
        }
    }
}

