using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmersProject
{
    class AgeGroupII : Swimmer
    {
        //Swimmers between the age of 16-25
        public AgeGroupII(string name, string sex, int age, double bestTime, string organisation) : base(name, sex, age, bestTime, organisation)
        {
            groupIdentifier = "AgeGroup 2";
        }
    }
}
