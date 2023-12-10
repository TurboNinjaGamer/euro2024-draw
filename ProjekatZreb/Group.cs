using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatZreb
{
    public class Group
    {
        public string name;
        public Slip[] teams;
        public PositionsPot positions;
        public Group(string name)
        {
            this.name = name;
            this.teams = new Slip[4];
            this.positions = new PositionsPot(4);
        }
        
        public void AddTeam(Slip team)
        {
            int position = positions.GetPosition();
            teams[position] = team;
        }
        public void AddHost(Slip team)
        {
            int position = positions.GetFirstPosition();
            teams[position] = team;
        }
    }
}
