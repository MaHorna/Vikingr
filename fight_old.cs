using System;
using System.Threading;

namespace nieco1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             int sila = 1200; int zdat = 125; int obrat = 10; int cha = 42; int inte = 24; int obr = 10;
            float fdmg = sila / 5;
            Math.Round(fdmg);
            int dmg = (int)fdmg;
            int hp = zdat * 5;
            float dodge = obrat / 2;
            Math.Round(dodge);
            float antidmg = (cha / 10) + (inte / 10) + obr;
            Math.Round(antidmg);
            int zantidmg = (int)antidmg;
            //koniec vypoctu hracovych statov
            //zaciatok vypoctu nepriatelovych statov
            Random r1 = new Random();
            int rdmg = r1.Next(dmg -= 10, dmg += 5);
            Random r2 = new Random();
            int rhp = r2.Next(hp -= 20, hp += 10);
            Random robrat = new Random();
            int robra = robrat.Next(obrat -= 10, obrat += 5);
            Random rcha = new Random();
            int rchar = rcha.Next(cha -= 10, cha += 5);
            Random rinte = new Random();
            int rint = rinte.Next(inte -= 10, inte += 5);
            Random robr = new Random();
            int robrana = robr.Next(obr -= 10, obr += 5);
            float rdodge = robra / 2;
            Math.Round(rdodge);
            float frantidmg = (rchar / 10) + (rint / 10) + robrana;
            //pridat obranu podla typu nepriatela 
            //( rozne druhy napr troll nebude mat brnko - slaba obrana)
            Math.Round(frantidmg);

            string menonep; //meno nepriatela vygeneruje nahodne
            menonep = "Lupič" ;

            Console.WriteLine("Na vyprave si sa stretol z {0}.", menonep);
            do
            {

                Console.Clear();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("         Tvoje staty                              Neprialove staty");
                Console.WriteLine("Tvoj priemerny dmg : "+ dmg + "                   Jeho priemerny dmg : " + rdmg);
                Console.WriteLine("Tvoje hp : " + hp + "                             Jeho hp : " + rhp);
                Console.WriteLine("Sanca na vyhnutie : " + dodge + "%                     Sanca na vyhnutie : " + rdodge + "%");
                Console.WriteLine("Tvoja obrana : " + antidmg + "                          Jeho obrana : " + frantidmg);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"); Oneskorenie06();
                Random rutokn = new Random();
                int run = rutokn.Next(rdmg -= 20, rdmg += 20); //velkost utoku nepriatela
                int kutokn = run - zantidmg; //velkost utoku nepriatela po odcitani obrany
                Random uskut = new Random();//sanca na utok nepriatela (pocitanie dodge) zaciatok
                int rusk = uskut.Next(1, 100);
                if (dodge <= rusk) { Console.WriteLine("{0} útočí u udeluje dmg {1} ", menonep, kutokn); Oneskorenie06(); hp -= kutokn; }
                else { Console.WriteLine("{0} ta netrafil. ", menonep); Oneskorenie06(); } //sanca na utok nepriatela (pocitanie dodge) koniec
                if (hp <= 0) goto skok ;
                Random rutok = new Random(); //velkost utoku postavy
                int ru = rutok.Next(rdmg -= 20, rdmg += 20);//velkost utoku postavy
                int rantidmg = (int)frantidmg;//velkost utoku postavy
                int kutok = ru - rantidmg; //velkost utoku postavy po odcitani obrany nepriatela
                Random uskuto = new Random(); //sanca na utok zaciatok
                int rusko = uskuto.Next(1, 100);
                if (rdodge <= rusko) { Console.WriteLine("Útočíš a udeluješ dmg {0} ", kutok); Oneskorenie06(); rhp -= kutok; }
                else { Console.WriteLine("Netrafil si sa. "); Oneskorenie06(); } //sanca na utok koniec
                if(rhp <= 0) goto skok;
            } while (hp > 0 && rhp > 0);
            skok:
            if (rhp < 0)
            {
                Console.WriteLine("                  ╔════════════╗");
                Console.WriteLine("                  ║  Vyhral si ║");
                Console.WriteLine("                  ╚════════════╝");
            }
            else
            {
                Console.WriteLine("                  ╔════════════╗");
                Console.WriteLine("                  ║ Prehral si ║");
                Console.WriteLine("                  ╚════════════╝");
            }
            Console.ReadLine();

        } 
        static void Oneskorenie06() { int milliseconds = 600; Thread.Sleep(milliseconds); }
    }
}