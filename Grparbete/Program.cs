using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grparbete
{
    class Program
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        static void Main(string[] args)
        {

            HockeyTeams shl = new HockeyTeams();
            
            Console.WriteLine(shl);
        }
    }
}
