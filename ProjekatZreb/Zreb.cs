using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatZreb
{
    public class Zreb
    {
        public List<Pot> pots;
        public char[] groupName = { 'A', 'B', 'C', 'D', 'E', 'F' };
        public Zreb(List<Pot> pots)
        {
            this.pots = pots;
        }
        public Tournament Draw()
        {
            Tournament tournament = new Tournament("EURO 2024");
            Group[] groups = new Group[6];
            for(int i = 0; i < groups.Length; i++)
            {
                Group group = new Group($"{groupName[i]}");
                groups[i] = group;
            }
            foreach(var pot in pots)
            {
                for (int i = 0; i < 6; i++)
                {
                    Slip team = pot.GetSlip();
                    if (pot.isFirstPot && i == 0)
                    {
                        groups[i].AddHost(team);
                    }
                    else
                    {
                        groups[i].AddTeam(team);
                    }
                }
            }
            foreach(var group in groups)
            {
                tournament.AddGroup(group);
            }
            return tournament;
        }
        public void DisplayTournament(Tournament tournament)
        {
            Console.WriteLine(tournament.name);
            Console.WriteLine();
            foreach(var group in tournament.groups)
            {
                Console.WriteLine("GRUPA " + group.name);
                Console.WriteLine("------------");
                foreach(var slip in group.teams)
                {
                    Console.WriteLine(slip.label);
                }
                Console.WriteLine();
            }
        }
    }
}
