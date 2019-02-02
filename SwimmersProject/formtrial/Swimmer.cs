using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmersProject
{
    abstract class Swimmer : ICloneable

    {
        public string name, sex, organisation;
        public int age;
        public double bestTime;
        public string groupIdentifier;

        public Swimmer(string name, string sex, int age, double bestTime, string organisation)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.bestTime = bestTime;
            this.organisation = organisation;
        }
        public Object Clone()
        {
             Object clone = null;

            clone = MemberwiseClone();

            return clone;
        }

    }
}
