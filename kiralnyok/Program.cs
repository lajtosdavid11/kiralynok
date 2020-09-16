using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiralynok
{
    class Tabla
    {
        private char UresCella;
        private char UresOszlopSzam;
        private char UresSorokSzama;
        private char[,] t;
        private int kiralynok;
        
        public void elhelyezes(int N)
        {
            //Véletlen helyiérték létrehozása:
            // - Random osztály értékkészlet: [0,7]
            // - Véletlen sor és oszlop
            // - Elhelyezzük a k-t;
            // - HA ÜRES -> "#"
            Console.Write("Hány királynő legyen : ");
            kiralynok = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < kiralynok; i++)
            {
                while (true)
                {
                    int sor = rnd.Next(0, 8);
                    int oszlop = rnd.Next(0, 8);
                    if (t[sor, oszlop] == '#')
                    {
                        t[sor, oszlop] = 'K';
                        break;
                    }

                }

            }





        }
        public void megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(t[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();


        }


        public Tabla(char ch)
        {
            t = new char[8, 8];
            UresCella = ch;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    t[i, j] = UresCella;
                }
            }
        }
        public int Uresoszlopok()
        {
            return 0;
        }
        public int uressor()
        {
            return 0;
        }

        public void fajlbair()
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Tabla t = new Tabla('#');
            
            Console.WriteLine("Üres tábla");
            t.megjelenit();
            t.elhelyezes(1);
            Console.WriteLine();
            t.megjelenit();




            Console.ReadKey();
        }
    }
}