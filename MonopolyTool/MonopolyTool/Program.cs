using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MonopolyTool
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] NamesHouse = { "Mediterranean Avenue", "Baltic Avenue", "Oriental Avenue", "Vermont Avenue", "Connectict Avenue", "St. Charles Place", "States Avenue", "Virginia Avenue", "St. James Place", "Tennessee Avenue", "New York Avenue", "Kentucky Avenue", "Indiana Avenue", "Illinois Avenue", "Atlantic Avenue", "Ventnor Avenue", "Marvin Gardens", "North Carolina", "Pacific Avenue", "Pennsylvania Avenue", "Park Place", "BoardWalk" };
            string[] RentHouse = { "2", "4" };

            string[] NamesHouses;

            StreamReader sr = new StreamReader((@"Rent.txt"));
            int length = int.Parse(sr.ReadLine());
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(NamesHouse[i]);
            }
            
            sr.Close();

            Console.ReadKey();
        }
    }
}
