using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grparbete
{

    class HockeyTeams 
    {
        

        public static void SHLteams()
        {
            Random r = new Random();
            

            var listOfTeams = new List<object>();

            listOfTeams.Add(new Lag("Djurgården", 70));
            listOfTeams.Add(new Lag("Färjestad", 85));
            listOfTeams.Add(new Lag("Örebro", 65));
            listOfTeams.Add(new Lag("Södertälje", 30));
            listOfTeams.Add(new Lag("Skellefteå", 75));
            listOfTeams.Add(new Lag("Växjö", 95));
            listOfTeams.Add(new Lag("Brynäs", 50));
            listOfTeams.Add(new Lag("HV71", 62));


           


            foreach (var i in listOfTeams)
            {
                Console.WriteLine(i);
                
            }
        }
    }
    class Lag : HockeyTeams
    {
        public Lag()
        {

        }
        public Lag(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
        private string name;
        private int skill;
        public string Name { get => name; set => name = value; }
        public int Skill { get => skill; set => skill = value; }

        public override string ToString()
        {
            return Name + ": " + Skill;
        }
    }
}




























