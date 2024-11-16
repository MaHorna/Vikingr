using System;
using static Vikingr.Metody;
using static Vikingr.RiesenieAkcii;
using static Vikingr.Stats;
using static Vikingr.UI;
using static Vikingr.VypisanieAkcii;
namespace Vikingr
{
    class Shop
    {
        public static int Durability;
        public static Item[] shopitemy = new Item[10];
        public static void WriteShop()
        {
            VypisAkcie("Shop");
            VykonajAkciu("Shop");
        }
        public static void Shopping(int n)
        {

            int pocetItemov = (LastX[1] - FirstX[1]) / 26;
            if (pocetItemov>9)
            {
                pocetItemov = 9;
            }
            for (int i = 0; i < pocetItemov; i++)
            {
                WriteItem(n, i);
            }
        }
        public static void WriteItem(int n, int i)
        {
            //╬  ═  ╠   ╦   ╩  ╔  ╚  ╝  ║  ╣ ╗
            Gotoxy((i * 26) + 3, 20);
            Console.WriteLine("╔══════════════════════╗");
            String[] kvalita = new String[] { "Príšern", "Hrozn", "Dostatočn", "Obyčajn", "Dobr", "Výborn", "Excelentn", "Jedinečn" };
            Double[] kvalitaMult = new Double[] { 0.3, 0.6, 0.9, 1.2, 1.5, 1.8, 2.1, 2.4 };

            String[] Helmy = new String[] { "Vlnená čiapka", "Kožená čiapka", "Helma", "Prilba" };
            String[] HelmyKoniec = new String[] { "á", "á", "á", "á" };

            String[] Brnenia = new String[] { "Košela", "Kožené brnenie", "Krúžkové brnenie", "Plátové brnenie" };
            String[] BrneniaKoniec = new String[] { "á", "é", "é", "é" };

            String[] Rukavice = new String[] { "Kožené rukavice", "Plátové rukavice" };
            String[] RukaviceKoniec = new String[] { "é", "é" };

            String[] Nohavice = new String[] { "Nohavice", "Plátové nohavice", "Kožené Brnenie" };
            String[] NohaviceKoniec = new String[] { "é", "é", "é" };

            String[] Topanky = new String[] { "Topánky", "Plátové topánky", "Kožené topánky" };
            String[] TopankyKoniec = new String[] { "é", "é", "é" };

            String[] LavaRuka = new String[] { "Štít", "Dýka" };
            String[] LavaRKoniec = new String[] { "ý", "á" };

            String[] PravaRuka = new String[] { "Kopija", "Meč", "Dýka", "Sekera", "Dvojsečna sekera", "Kladivo", "Oštep", "Luk", "Obojručný meč" };
            String[] PravaRKoniec = new String[] { "á", "ý", "á", "á", "á", "é", "ý", "ý", "ý" };

            String[] Doplnok = new String[] { "Náhrdelník", "Prsteň", "Náramok" };
            String[] DoplnokKoniec = new String[] { "ý", "ý", "ý" };

            String[] Pristavok = new String[] {"Dvojitej kvality", "Absolútneho zúfalstva", "Nekončiacej pýchy", "Neúprosnej váhy", "Nemožnej špinavosti", "Nezasiahnutelnosti", "Obyčajnosti", "Nádeje","Kauzálneho skonu","Špinavej korupcie",
                "Kvalitnej smrti","So škvrnami od krvy","Čistej špiny","Škaredej krásy","Ľadového ohňa","Horúceho ľadu","Bez záručnej doby","Tvojej mamy"};

            int pristavok = Pristavok.Length;
            Random random = new Random();
            int rnd3 = random.Next(pristavok);
            int rnd;
            if (Town == "Skalamyrr")
            {
                rnd = random.Next(7);
            }
            else
            {
                rnd = random.Next(5);
            }
            int lngth = kvalita[rnd].Length + 1;
            int rnd7 = random.Next(50); int rnd8 = random.Next(50);
            double[] tmp1 = { 0.0, 0.0, 0.0, 0.0, 0.0 }; int[] tmp2 = { 0, 0, 0, 0, 0 };
            Item item = new Item("", 0, 0, 0, tmp1, tmp2, 0, 0);
            shopitemy[i] = item;
            shopitemy[i].TypeOfItem = n;
            switch (n)
            {
                case 1:
                    int rnd2 = random.Next(4);
                    Gotoxy((i * 26) + 3, 21);
                    Console.Write("║ " + kvalita[rnd] + HelmyKoniec[rnd2] + DurabilEnder(kvalitaMult[rnd], lngth, i));
                    lngth = Helmy[rnd2].Length;
                    Gotoxy((i * 26) + 3, 22);
                    Console.Write("║ " + Helmy[rnd2] + SpacesAndEnder(lngth));
                    lngth = Pristavok[rnd3].Length;
                    shopitemy[i].Name = kvalita[rnd] + HelmyKoniec[rnd2] + " " + Helmy[rnd2] + " ";
                    double rnd9 = random.Next(7, 13);
                    shopitemy[i].AttackDamage = 0;
                    shopitemy[i].Armour = Math.Round(kvalitaMult[rnd] * 150 * kvalitaMult[rnd] * (rnd9 / 10), MidpointRounding.AwayFromZero); break;
                case 2:
                    rnd2 = random.Next(4);
                    Gotoxy((i * 26) + 3, 21);
                    Console.Write("║ " + kvalita[rnd] + BrneniaKoniec[rnd2] + DurabilEnder(kvalitaMult[rnd], lngth, i));
                    lngth = Brnenia[rnd2].Length;
                    Gotoxy((i * 26) + 3, 22);
                    Console.Write("║ " + Brnenia[rnd2] + SpacesAndEnder(lngth));
                    lngth = Pristavok[rnd3].Length;
                    shopitemy[i].Name = kvalita[rnd] + BrneniaKoniec[rnd2] + " " + Brnenia[rnd2] + " ";
                    rnd9 = random.Next(7, 13);
                    shopitemy[i].AttackDamage = 0;
                    shopitemy[i].Armour = Math.Round(kvalitaMult[rnd] * 150 * kvalitaMult[rnd] * (rnd9 / 10), MidpointRounding.AwayFromZero); break;
                case 3:
                    rnd2 = random.Next(2);
                    Gotoxy((i * 26) + 3, 21);
                    Console.Write("║ " + kvalita[rnd] + RukaviceKoniec[rnd2] + DurabilEnder(kvalitaMult[rnd], lngth, i));
                    lngth = Rukavice[rnd2].Length;
                    Gotoxy((i * 26) + 3, 22);
                    Console.Write("║ " + Rukavice[rnd2] + SpacesAndEnder(lngth));
                    lngth = Pristavok[rnd3].Length;
                    shopitemy[i].Name = kvalita[rnd] + RukaviceKoniec[rnd2] + " " + Rukavice[rnd2] + " ";
                    rnd9 = random.Next(7, 13);
                    shopitemy[i].AttackDamage = 0;
                    shopitemy[i].Armour = Math.Round(kvalitaMult[rnd] * 150 * kvalitaMult[rnd] * (rnd9 / 10), MidpointRounding.AwayFromZero); break;
                case 4:
                    rnd2 = random.Next(3);
                    Gotoxy((i * 26) + 3, 21);
                    Console.Write("║ " + kvalita[rnd] + NohaviceKoniec[rnd2] + DurabilEnder(kvalitaMult[rnd], lngth, i));
                    lngth = Nohavice[rnd2].Length;
                    Gotoxy((i * 26) + 3, 22);
                    Console.Write("║ " + Nohavice[rnd2] + SpacesAndEnder(lngth));
                    lngth = Pristavok[rnd3].Length;
                    shopitemy[i].Name = kvalita[rnd] + NohaviceKoniec[rnd2] + " " + Nohavice[rnd2] + " ";
                    rnd9 = random.Next(7, 13);
                    shopitemy[i].AttackDamage = 0;
                    shopitemy[i].Armour = Math.Round(kvalitaMult[rnd] * 150 * kvalitaMult[rnd] * (rnd9 / 10), MidpointRounding.AwayFromZero); break;
                case 5:
                    rnd2 = random.Next(3);
                    Gotoxy((i * 26) + 3, 21);
                    Console.Write("║ " + kvalita[rnd] + TopankyKoniec[rnd2] + DurabilEnder(kvalitaMult[rnd], lngth, i));
                    lngth = Topanky[rnd2].Length;
                    Gotoxy((i * 26) + 3, 22);
                    Console.Write("║ " + Topanky[rnd2] + SpacesAndEnder(lngth));
                    lngth = Pristavok[rnd3].Length;
                    shopitemy[i].Name = kvalita[rnd] + TopankyKoniec[rnd2] + " " + Topanky[rnd2] + " ";
                    rnd9 = random.Next(7, 13);
                    shopitemy[i].AttackDamage = 0;
                    shopitemy[i].Armour = Math.Round(kvalitaMult[rnd] * 150 * kvalitaMult[rnd] * (rnd9 / 10), MidpointRounding.AwayFromZero); break;
                case 6:
                    rnd2 = random.Next(2);
                    Gotoxy((i * 26) + 3, 21);
                    Console.Write("║ " + kvalita[rnd] + LavaRKoniec[rnd2] + DurabilEnder(kvalitaMult[rnd], lngth, i));
                    lngth = LavaRuka[rnd2].Length;
                    Gotoxy((i * 26) + 3, 22);
                    Console.Write("║ " + LavaRuka[rnd2] + SpacesAndEnder(lngth));
                    lngth = Pristavok[rnd3].Length;
                    shopitemy[i].Name = kvalita[rnd] + LavaRKoniec[rnd2] + " " + LavaRuka[rnd2] + " ";
                    rnd9 = random.Next(7, 13);
                    shopitemy[i].AttackDamage = 0;
                    shopitemy[i].Armour = Math.Round(kvalitaMult[rnd] * 150 * kvalitaMult[rnd] * (rnd9 / 10), MidpointRounding.AwayFromZero);

                    break;
                case 7:
                    rnd2 = random.Next(9);
                    Gotoxy((i * 26) + 3, 21);
                    Console.Write("║ " + kvalita[rnd] + PravaRKoniec[rnd2] + DurabilEnder(kvalitaMult[rnd], lngth, i));
                    lngth = PravaRuka[rnd2].Length;
                    Gotoxy((i * 26) + 3, 22);
                    Console.Write("║ " + PravaRuka[rnd2] + SpacesAndEnder(lngth));
                    lngth = Pristavok[rnd3].Length;
                    shopitemy[i].Name = kvalita[rnd] + PravaRKoniec[rnd2] + " " + PravaRuka[rnd2] + " ";
                    rnd9 = random.Next(7, 13);
                    double damage = Math.Round(Math.Pow(kvalitaMult[rnd] * 10, kvalitaMult[rnd]) * (rnd9 / 10) + 10);
                    shopitemy[i].AttackDamage = damage;
                    rnd9 = random.Next(7, 13);
                    shopitemy[i].Armour = Math.Round(kvalitaMult[rnd] * 150 * kvalitaMult[rnd] * (rnd9 / 10), MidpointRounding.AwayFromZero);
                    break;

                case 8:
                    rnd2 = random.Next(3);
                    Gotoxy((i * 26) + 3, 21);
                    Console.Write("║ " + kvalita[rnd] + DoplnokKoniec[rnd2] + DurabilEnder(kvalitaMult[rnd], lngth, i));
                    lngth = Doplnok[rnd2].Length;
                    Gotoxy((i * 26) + 3, 22);
                    Console.Write("║ " + Doplnok[rnd2] + SpacesAndEnder(lngth));
                    lngth = Pristavok[rnd3].Length;
                    shopitemy[i].Name = kvalita[rnd] + DoplnokKoniec[rnd2] + " " + Doplnok[rnd2] + " ";
                    shopitemy[i].AttackDamage = (kvalitaMult[rnd] * kvalitaMult[rnd] * (100 - rnd7) / 100) - 1;
                    shopitemy[i].Armour = (kvalitaMult[rnd] * kvalitaMult[rnd] * (100 - rnd8) / 100) - 1;
                    if (shopitemy[i].AttackDamage < 1)
                    {
                        shopitemy[i].AttackDamage = 1;
                    }
                    if (shopitemy[i].Armour < 1)
                    {
                        shopitemy[i].Armour = 1;
                    }
                    break;
            }
            Gotoxy((i * 26) + 3, 23);
            Console.Write("║ " + Pristavok[rnd3] + SpacesAndEnder(lngth));
            shopitemy[i].Name += Pristavok[rnd3];
            Gotoxy((i * 26) + 3, 24);
            Console.WriteLine("╠══════════════════════╣");
            double pocetstatov = kvalitaMult[rnd] * 3;
            int rnd4 = random.Next(7, 13);
            int statsnumber = (int)Math.Round(pocetstatov * (rnd4 / 10), MidpointRounding.AwayFromZero);
            int j;
            for (j = 0; j < statsnumber; j++)
            {
                rnd4 = random.Next(3);
                if (rnd4 != 0)
                {
                    int rnd5 = random.Next(5); double rnd6 = random.Next(7, 13);
                    double statamount = Math.Round((kvalitaMult[rnd] * kvalitaMult[rnd] * kvalitaMult[rnd]) * 100 * rnd6 / 10);
                    shopitemy[i].Adders[rnd5] += (int)statamount;
                    Gotoxy((i * 26) + 3, 25 + j);

                    switch (rnd5)
                    {
                        case 0:
                            lngth = 3 + 4 + statamount.ToString().Length - 1;
                            Console.Write("║ Sila +" + statamount + SpacesAndEnder(lngth));
                            break;
                        case 1:
                            lngth = 3 + 9 + statamount.ToString().Length - 1;
                            Console.Write("║ Obratnosť +" + statamount + SpacesAndEnder(lngth));
                            break;
                        case 2:
                            lngth = 3 + 5 + statamount.ToString().Length - 1;
                            Console.Write("║ Výdrž +" + statamount + SpacesAndEnder(lngth));
                            break;
                        case 3:
                            lngth = 3 + 8 + statamount.ToString().Length - 1;
                            Console.Write("║ Charizma +" + statamount + SpacesAndEnder(lngth));
                            break;
                        case 4:
                            lngth = 3 + 12 + statamount.ToString().Length - 1;
                            Console.Write("║ Inteligencia +" + statamount + SpacesAndEnder(lngth));
                            break;
                    }

                }
                else
                {
                    Gotoxy((i * 26) + 3, 25 + j);
                    int rnd5 = random.Next(5);
                    double statamount = kvalitaMult[rnd] + random.Next(-1, 1);
                    if (statamount <= 0)
                    {
                        statamount = random.Next(0, 2);
                        statamount += 0.1;
                    }
                    shopitemy[i].Multiplicators[rnd5] += statamount;
                    switch (rnd5)
                    {
                        case 0:
                            lngth = 3 + 4 + statamount.ToString().Length - 1;
                            Console.Write("║ Sila *" + statamount + SpacesAndEnder(lngth));
                            break;
                        case 1:
                            lngth = 3 + 9 + statamount.ToString().Length - 1;
                            Console.Write("║ Obratnosť *" + statamount + SpacesAndEnder(lngth));
                            break;
                        case 2:
                            lngth = 3 + 5 + statamount.ToString().Length - 1;
                            Console.Write("║ Výdrž *" + statamount + SpacesAndEnder(lngth));
                            break;
                        case 3:
                            lngth = 3 + 8 + statamount.ToString().Length - 1;
                            Console.Write("║ Charizma *" + statamount + SpacesAndEnder(lngth));
                            break;
                        case 4:
                            lngth = 3 + 12 + statamount.ToString().Length - 1;
                            Console.Write("║ Inteligencia *" + statamount + SpacesAndEnder(lngth));
                            break;
                    }
                }
            }
            double rndMult = random.Next(1, 3);
            shopitemy[i].Value = (int)Math.Round(Math.Pow(200, kvalitaMult[rnd]) * rndMult);//VALUE
            //armour ,attack, value vypis
            int riadok = 0;

            if (shopitemy[i].AttackDamage != 0)
            {
                Gotoxy((i * 26) + 3, 25 + j + riadok);
                riadok++;
                lngth = shopitemy[i].AttackDamage.ToString().Length + 7;
                Console.Write("║ Attack " + shopitemy[i].AttackDamage + SpacesAndEnder(lngth));
            }
            if (shopitemy[i].Armour != 0)
            {
                Gotoxy((i * 26) + 3, 25 + j + riadok);
                riadok++;
                lngth = shopitemy[i].Armour.ToString().Length + 7;
                Console.Write("║ Armour " + shopitemy[i].Armour + SpacesAndEnder(lngth));
            }

            Gotoxy((i * 26) + 3, 25 + j + riadok);
            lngth = (shopitemy[i].Value * 2).ToString().Length + 6;
            Console.Write("║ Costs " + shopitemy[i].Value * 2 + SpacesAndEnder(lngth));
            Gotoxy((i * 26) + 3, 25 + j + riadok + 1);
            Console.WriteLine("╚══════════════════════╝");
            Gotoxy((i * 26) + 3, 25 + j + riadok + 2);
            Console.WriteLine("        <---{0}--->       ",i);

        }

        public static string SpacesAndEnder(int lngth)
        {
            int n = 22; String s = "";
            for (int i = 0; i < n - lngth - 1; i++)
            {
                s += " ";
            }
            s += "║";
            return s;
        }
        public static string DurabilEnder(double durab, int lngth, int n)
        {
            Durability = Convert.ToInt32(durab * durab * 1000);

            string medzery = " ";

            Random randm = new Random();
            int rnd = randm.Next(2);
            if (rnd == 0)
            {
                rnd = randm.Next(20) + 1;
                Durability = (Durability / 100) * (100 - rnd);
                if (Durability < 1)
                {
                    Durability = randm.Next(50) + 50;
                }
            }
            else
            {
                rnd = randm.Next(50) + 1;
                Durability = (Durability / 100) * (100 - rnd);
                if (Durability < 1)
                {
                    Durability = randm.Next(60) + 1;
                }
            }
            string output = "hp " + Durability;
            for (int i = 0; i < 22 - lngth - 3 - output.Length; i++)
            {
                medzery += " ";
            }
            shopitemy[n].Durability = Durability;
            return medzery + output + " ║";
        }
    }
}
