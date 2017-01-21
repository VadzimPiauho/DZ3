using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{

    public class tank
    {
        protected string name;
        protected int boekomplekt;
        protected int lvlBroni;
        protected int lvlManevr;
        public tank(int boekomplekt, int lvlBroni, int lvlManevr, string name)
        {

            this.boekomplekt = boekomplekt;
            this.lvlBroni = lvlBroni;
            this.lvlManevr = lvlManevr;
            this.name = name;
        }
        public tank()
        {
            boekomplekt = 0;
            lvlBroni = 0;
            lvlManevr = 0;
            name = "null";
        }
        public void Print()
        {
            Console.WriteLine("name - " + name);
            Console.WriteLine("boekomplekt = " + boekomplekt + " lvlBroni = " + lvlBroni + " lvlManevr = " + lvlManevr);
        }

        public static tank operator *(tank T34, tank pantera)
        {
            if (T34.boekomplekt > pantera.boekomplekt && T34.lvlBroni > pantera.lvlBroni)
            {
                return T34;
            }
            if (T34.boekomplekt > pantera.boekomplekt && T34.lvlManevr > pantera.lvlManevr)
            {
                return T34;
            }
            if (T34.lvlBroni > pantera.lvlBroni && T34.lvlManevr > pantera.lvlManevr)
            {
                return T34;
            }
            else
            {
                return pantera;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            tank[] VIN = new tank[5];
            tank[] T34 = new tank[5];
            for (int i = 0; i < T34.Length; i++)
            {
                VIN[i] = new tank();
            }
            for (int i = 0; i < T34.Length; i++)
            {
                T34[i] = new tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "T34");
            }
            tank[] pantera = new tank[5];
            for (int i = 0; i < T34.Length; i++)
            {
                pantera[i] = new tank(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), "pantera");
            }
            for (int i = 0; i < 5; i++)
            {
                T34[i].Print();
                pantera[i].Print(); ;
                VIN[i] = T34[i] * pantera[i];
                Console.WriteLine();
                Console.WriteLine($"В {i + 1} схватке победил");
                VIN[i].Print();
                Console.WriteLine();
                Console.WriteLine();
            }




        }
    }
}
