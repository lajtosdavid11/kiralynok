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
       
        
        public void elhelyezes(int N)
        {
            //Véletlen helyiérték létrehozása:
            // - Random osztály értékkészlet: [0,7]
            // - Véletlen sor és oszlop
            // - Elhelyezzük a k-t;
            // - HA ÜRES -> "#"
            

            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                bool igaz = true;
                while (igaz)
                {
                    int sor = rnd.Next(0, 8);
                    int oszlop = rnd.Next(0, 8);
                    if (t[sor, oszlop] == '#')
                    {
                        t[sor, oszlop] = 'K';
                        igaz = false;
                    }

                }

            }




        }
        public void megjelenit()
        {
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0} ", t[i, j]);

                }
                Console.Write("\n");
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
        public bool Uresoszlopok(int oszlop)
        {
            int i = 0;
            bool van = true;
            while (van && i<8)
            {
                if (t[i,oszlop] =='K')
                {
                    van = false;
                }
                i++;
            }
            return true;
        }
        public bool uressor(int sor)
        {
            int i = 0;
            bool van = true;
            while (van && i < 8)
            {
                if (t[sor, i] == 'K')
                {
                    van = false;
                }
                i++;
            }
            return true;

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
            Console.WriteLine("Üres tábla:");
            t.megjelenit();
            t.elhelyezes(1);
            Console.WriteLine("\n");
            t.megjelenit();
            Console.WriteLine("Van-e az oszlopban király?" , t.Uresoszlopok(1));

            Console.WriteLine("Van a sorban király?" , t.uressor(1));




            Console.ReadKey();
        }
    }
}