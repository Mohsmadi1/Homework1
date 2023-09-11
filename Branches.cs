using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadi_task
{
    internal class Branches
    {

        public string branch1Name = "Lalala Restaurant";
        public string opening1Date = "16/10/2022";
        public string Branch1Location = "Abdali Boulevard";
        public string branch2Name = "Light Restaurant";
        public string opening2Date = "1/1/2023";
        public string Branch2Location = "Tabarbour";
        public string branch3Name = "Dark Restaurant";
        public string opening3Date = "7/4/2023";
        public string Branch3Location = "Abdoun";
        public void FirstBranch()
        {
            Console.WriteLine("This is the first branch");
            Resturant Resturant1 = new Resturant(branch1Name, opening1Date, Branch1Location);
        }

        public void SecondBranch()
        {
            Console.WriteLine("This is the second branch");
            Resturant Resturant2 = new Resturant(branch2Name, opening2Date, Branch2Location);
        }

        public void ThirdBranch()
        {
            Console.WriteLine("This is the Third branch");
            Resturant Resturant3 = new Resturant(branch3Name, opening3Date, Branch3Location);
        }


    }
}
