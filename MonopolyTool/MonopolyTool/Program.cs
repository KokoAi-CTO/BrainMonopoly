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

            string NamesHouses;

            
            
            


            StreamReader sr = new StreamReader("Rent.txt");


            int i;
            int[] marks = new int[22];

            for (i = 0; i < marks.Length; i++)
            {

                {
                    marks[i] = int.Parse(sr.ReadLine());
                }

                {
                    Console.WriteLine(marks[i]);

                }
            }
            sr.Close();

            string[,] array = new string[,]
              {

            {"1010", "109", "108", "107", "106", "105", "104", "103", "102", "101", "100"},
            {"100", "90", "80", "70", "60", "50", "40", "30", "20", "10", "00" },
            {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "010"},
            {"010", "110", "210", "310", "410", "510", "610", "710", "810", "910", "1010"},

               };





            sr.Close();

            Console.ReadKey();
        }
    }
}
