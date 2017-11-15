using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grparbete
{

    class HockeyTeams : ITeam
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        class SHL : HockeyTeams
        {
            public SHL(string name, int skill)
            {
                this.Name = name;
                this.Skill = skill;

                
            }
            public SHL()
            {
                SHL team = new SHL();
                team = new SHL("Färjestad", 70); 
                team = new SHL("Frölunda", 65);
                Console.WriteLine(team);

                

            }
        }
    }
}
