using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmersProject
{
    class SwimmersCache
    {
        //Different lists for contatining the swimmers data based on different categories

        static List<AgeGroupI> ageGroupIList = new List<AgeGroupI>();
        static List<AgeGroupII> ageGroupIIList = new List<AgeGroupII>();
        static List<AgeGroupIII> ageGroupIIIList = new List<AgeGroupIII>();

        static List<Swimmer> allSwimmersList = new List<Swimmer>();
        static List<Swimmer> temporarySwimmersList = new List<Swimmer>();

        public static void loadCache()
        {
            //Create or insert the swimmers data
            //Sample Swimmers 
            Swimmer swimmer1 = new AgeGroupI("Abebe", "Male", 12, 14.2, "Addis Ababa");
            allSwimmersList.Add((Swimmer) swimmer1.Clone());
            Swimmer swimmer2 = new AgeGroupI("Beleteche", "Female", 10, 15.2, "Oromia");
            allSwimmersList.Add((Swimmer) swimmer2.Clone());
            Swimmer swimmer3 = new AgeGroupI("Chemeso", "Male", 15, 13.2, "Gambela");
            allSwimmersList.Add((Swimmer) swimmer3.Clone());
            Swimmer swimmer4 = new AgeGroupII("Debebe", "Male", 20, 12.1, "Amhara");
            allSwimmersList.Add((Swimmer) swimmer4.Clone());
            Swimmer swimmer5 = new AgeGroupII("Elehneshe", "Female", 21, 12.2, "Debube");
            allSwimmersList.Add((Swimmer) swimmer5.Clone());
            Swimmer swimmer6 = new AgeGroupII("Ferahushe", "Female", 22, 13.0, "Tigray");
            allSwimmersList.Add((Swimmer) swimmer6.Clone());
            Swimmer swimmer7 = new AgeGroupIII("Gurumela", "Male", 27, 12.5, "Afar");
            allSwimmersList.Add((Swimmer) swimmer7.Clone());
            Swimmer swimmer8 = new AgeGroupIII("Hirbana", "Female", 27, 12.4, "Benishangul");
            allSwimmersList.Add((Swimmer) swimmer8.Clone());
            Swimmer swimmer9 = new AgeGroupIII("Illoli", "Female", 28, 12.4, "Somalia");
            allSwimmersList.Add((Swimmer) swimmer9.Clone());
            Swimmer swimmer10 = new AgeGroupII("Jobberi", "Male", 23, 11.9, "Harar");
            allSwimmersList.Add((Swimmer) swimmer10.Clone());

            loadGroupLists();
        }

        static public void loadGroupLists()
        {
            foreach (Swimmer swimmer in allSwimmersList)
            {
                if (swimmer.groupIdentifier == "AgeGroup 1")
                {
                    ageGroupIList.Add((AgeGroupI)swimmer);
                }
                else if (swimmer.groupIdentifier == "AgeGroup 2")
                {
                    ageGroupIIList.Add((AgeGroupII)swimmer);
                }
                else
                {
                    ageGroupIIIList.Add((AgeGroupIII)swimmer);
                }
            }
        }

        public static List<Swimmer> getBySex(String gender)
        {
            temporarySwimmersList = new List<Swimmer>();
            foreach (Swimmer swimmer in allSwimmersList)
            {
                if (swimmer.sex == gender)
                {
                    temporarySwimmersList.Add(swimmer);
                }
                else
                {
                    continue;
                }
            }

            return temporarySwimmersList;
        }

        public static List<Swimmer> getAgeGroupI()
        {
            List<Swimmer> returnList = new List<Swimmer>();
            foreach (AgeGroupI swimmer in ageGroupIList)
            {
                returnList.Add(swimmer);
            }
            return returnList;
        }

        public static List<Swimmer> getAgeGroupII()
        {
            List<Swimmer> returnList = new List<Swimmer>();
            foreach (AgeGroupII swimmer in ageGroupIIList)
            {
                returnList.Add(swimmer);
            }
            return returnList;
        }

        public static List<Swimmer> getAgeGroupIII()
        {
            List<Swimmer> returnList = new List<Swimmer>();
            foreach (AgeGroupIII swimmer in ageGroupIIIList)
            {
                returnList.Add(swimmer);
            }
            return returnList;
        }

        public static List<Swimmer> getAllSwimmers()
        {
            return allSwimmersList;
        }
    }
}
