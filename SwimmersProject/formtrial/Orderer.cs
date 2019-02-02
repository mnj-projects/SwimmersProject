using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmersProject
{
    class Orderer
    {
    
        public List<Swimmer> orderByAgeGroup(int groupId)
        {
            List<Swimmer> returnList = new List<Swimmer>();
            if (groupId == 1)
            {
                foreach (Swimmer swimmer in sorterByTimeAsc(SwimmersCache.getAgeGroupI()))
                {
                    returnList.Add(swimmer);
                }
            } else if(groupId == 2) {
                foreach (Swimmer swimmer in sorterByTimeAsc(SwimmersCache.getAgeGroupII()))
                {
                    returnList.Add(swimmer);
                }
            } else {
                foreach (Swimmer swimmer in sorterByTimeAsc(SwimmersCache.getAgeGroupIII()))
                {
                    returnList.Add(swimmer);
                }
            }
            return returnList;
        }

        public List<Swimmer> orderByTime()
        {
            List<Swimmer> returnList = new List<Swimmer>();
            foreach (Swimmer swimmer in sorterByTimeAsc(SwimmersCache.getAllSwimmers()))
            {
                returnList.Add(swimmer);
            }
            return returnList;
        }

        public List<Swimmer> orderBySex(int genderId)
        {
            //1 == Female
            //2 == Male
            List<Swimmer> returnList = new List<Swimmer>();
            if (genderId == 1)
            {
                returnList = SwimmersCache.getBySex("Female");
            }
            else
            {
                returnList = SwimmersCache.getBySex("Male");
            }

            return returnList;
           
        }

        public List<Swimmer> orderByAge()
        {
            List<Swimmer> returnList = new List<Swimmer>();
            foreach (Swimmer swimmer in sorterByAgeAsc(SwimmersCache.getAllSwimmers()))
            {
                returnList.Add(swimmer);
            }
            return returnList;
        }

        private IEnumerable<Swimmer> sorterByTimeAsc(List<Swimmer> listToBeSorted)
        {
            IEnumerable<Swimmer> sortedList = listToBeSorted.OrderBy(swimmer => swimmer.bestTime);
            return sortedList;
        }

        private IEnumerable<Swimmer> sorterByAgeAsc(List<Swimmer> listToBeSorted)
        {
            IEnumerable<Swimmer> sortedList = listToBeSorted.OrderBy(swimmer => swimmer.age);
            return sortedList;
        }

    }
}
