using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekatZreb
{
    public class Tournament
    {
        public string name;
        public List<Group> groups;
        public Tournament(string name)
        {
            this.name = name;
            this.groups = new List<Group>();
        }
        public void AddGroup(Group group)
        {
            groups.Add(group);
        }
    }
}
