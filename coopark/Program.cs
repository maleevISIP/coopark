using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coopark
{

    class zPark
    {
        public string pet;
        public string sex;
        public string name;
        public int kost;
        internal int kolvo;
    
}
class Program
    {
        static void Main(string[] args)
        {

        zPark petOne = new zPark();

            petOne.pet = Console.ReadLine();
            petOne.sex = Console.ReadLine();
            petOne.name = Console.ReadLine();
            petOne.kost = Convert.ToInt32(Console.ReadLine());
            petOne.kolvo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(petOne.pet + " " + petOne.sex + " " + petOne.name + " " + petOne.kost + " " + petOne.kolvo);
            Console.ReadKey();
        }
    }
}
