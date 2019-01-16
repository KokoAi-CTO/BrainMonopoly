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

            StreamReader sr = new StreamReader("HouseName.txt");
            StreamReader RS = new StreamReader("Rent.txt");


            string[] House = new string[22];

            for (int i = 0; i < House.Length; i++)
            {

                {
                    House[i] = sr.ReadLine();
                }

                {
                    Console.WriteLine(House[i]);

                }
            }
   
            string[] Rent = new string[22];

            for (int i = 0; i < Rent.Length; i++)
            {

                {
                    Rent[i] = RS.ReadLine();
                }

                {
                    Console.WriteLine(Rent[i]);

                }
            }
            RS.Close();

            string[,] array = new string[,]
              {

            {"1010", "109", "108", "107", "106", "105", "104", "103", "102", "101", "100"},
            {"100", "90", "80", "70", "60", "50", "40", "30", "20", "10", "00" },
            {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "010"},
            {"010", "110", "210", "310", "410", "510", "610", "710", "810", "910", "1010"},

               };



            Console.ReadKey();
        }
    }
}
