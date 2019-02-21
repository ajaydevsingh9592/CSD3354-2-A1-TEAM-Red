using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_2_A1_TEAM_Red
{
    class UsingRecursion
    {
        // Create an application which 
        // calculates the sum of all the numbers from n to m recursively:

        public static int CalculateRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateRecursively(n, m);
            }
            return sum;
        }


    }

    class CountrySide
    {
        static void Main()
        {
            new CountrySide().Run();
        }


        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;

        public void travelVillages(Village currentVillage)
        {
            if (currentVillage.isAstrildgeHere)
            {
                Console.WriteLine("I found Dear Astrildge in 0", currentVillage.VillageName);
                Console.WriteLine("**** FEELING HAPPY ****");
                return;
            }
            travelVillages(currentVillage.west);
            travelVillages(currentVillage.east);
        }


        public void Run()
        {
            Alst = new Village("Alstr", false);
            Schvenig = new Village("Schvenig", false);
            Wessig = new Village("Wessig", false);
            Alst.distanceToEastVillage = 14;
            Alst.distanceToWestVillage = 19;
            Alst.west = Schvenig;
            Alst.east = Wessig;

            //
            Schvenig.west = null;
            Schvenig.east = null;

            //
            Wessig.west = null;
            Wessig.east = null;
        }

    }
    class Village
    {
        public Village(string _villageName, bool _isAHere)
        {
            isAstrildgeHere = _isAHere;
            VillageName = _villageName;
        }

        public Village west;
        public Village east;
        public string VillageName;
        public int distanceToEastVillage;
        public int distanceToWestVillage;
        public bool isAstrildgeHere;
    }


}
