using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmersProject
{
    class AgeGroupI : Swimmer
    {
        //Swimmers between the age of 10-15
        public AgeGroupI(string name, string sex, int age, double bestTime, string organisation) : base(name, sex, age, bestTime, organisation)
        {
            groupIdentifier = "AgeGroup 1";
        }

    }
}
