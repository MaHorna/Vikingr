using System;
using static Vikingr.Item;
using static Vikingr.Metody;
using static Vikingr.Stats;
using static Vikingr.UI;


namespace Vikingr
{
    class UpdateWindows
    {
        public static int LastLineCount = 0;
        public static void DetermineDurabColor(int n)
        {
            if (itemy[n].Durability < 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (itemy[n].Durability < 200)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (itemy[n].Durability < 400)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (itemy[n].Durability < 800)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void UpdateStats()
        {
            int CharacterStartWritePos = ((LastX[2] - FirstX[2]) / 2) - 4;
            Gotoxy(FirstX[2] + CharacterStartWritePos, FirstY[2] + 1);
            DetermineDurabColor(0);
            Console.WriteLine("    O");

            Gotoxy(FirstX[2] + CharacterStartWritePos, FirstY[2] + 2);
            DetermineDurabColor(6);
            Console.Write("\\ ");
            DetermineDurabColor(2);
            Console.Write("/");
            DetermineDurabColor(1);
            Console.Write("( )");
            DetermineDurabColor(2);
            Console.WriteLine("\\");

            Gotoxy(FirstX[2] + CharacterStartWritePos, FirstY[2] + 3);
            DetermineDurabColor(6);
            Console.Write(" ' ");
            DetermineDurabColor(3);
            Console.Write("| |");
            DetermineDurabColor(2);
            Console.Write(" '");
            DetermineDurabColor(5);
            Console.WriteLine("O");

            Gotoxy(FirstX[2] + CharacterStartWritePos, FirstY[2] + 4);
            DetermineDurabColor(4);
            Console.Write("   ' '");
            Console.ResetColor();

            /*
                   O
               \ /( )\
                ' | | 'O
                  ' '
            */
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6);
            Console.WriteLine("Helma: " + Helma);
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 1);
            Console.WriteLine("Brnenie: " + Brnenie);
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 2);
            Console.WriteLine("Rukavice: " + Rukavice);
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 3);
            Console.WriteLine("Nohavice: " + Nohavice);
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 4);
            Console.WriteLine("Topanky: " + Topanky);
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 5);
            Console.WriteLine("Lavá ruka: " + LavaR);
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 6);
            Console.WriteLine("Pravá ruka: " + PravaR);
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 7);
            Console.WriteLine("Doplnok: " + Doplnok);
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 8);
            Console.WriteLine("Sila: " + ((Sila + AddStatsSumer[0])*MultiplyStatsSumer[0]));
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 9);
            Console.WriteLine("Obratnosť: " + ((Obrat + AddStatsSumer[1]) * MultiplyStatsSumer[1]));
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 10);
            Console.WriteLine("Výdrž: " + ((Vydrz + AddStatsSumer[2]) * MultiplyStatsSumer[2]));
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 11);
            Console.WriteLine("Charizma: " + ((Chari + AddStatsSumer[3]) * MultiplyStatsSumer[3]));
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 12);
            Console.WriteLine("Inteligencia: " + ((Intel + AddStatsSumer[4]) * MultiplyStatsSumer[4]));
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 13);
            Console.WriteLine("Útok: " + (Utok+AttackDamageSum));
            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 14);
            Console.WriteLine("Obrana: " + (Obrana+ArmorSum));

            Gotoxy(FirstX[2] + 1, FirstY[2] + 6 + 16);
            Console.WriteLine("Money: " + Zlatky + "G, "+Strieborne+"S, "+Medene+"C");

        }
        public static void UpdateTandS()
        {
            VypocetRokovAMesiacov();
            string output = "";
            for (int i = 0; i < LastX[4] - FirstX[4] + 1; i++)
            {
                output += " ";
            }
            for (int i = 0; i < LastY[4] - FirstY[4] + 1; i++)
            {
                Gotoxy(FirstX[4], i + FirstY[4]);
                Console.Write(output);
            }
            Gotoxy(FirstX[4] + 1, FirstY[4] + 1);
            Console.WriteLine("Day {0},Month {1},Year {2}", Dni, Mesiacov, Rokov);
            Gotoxy(FirstX[4] + 1, FirstY[4] + 2);
            Console.WriteLine("Its {0} hours", Hodin);
            Gotoxy(FirstX[4] + 1, FirstY[4] + 3);
            Console.WriteLine("Score: " + Skore);
            Gotoxy(FirstX[4] + 1, FirstY[4] + 4);
            Console.WriteLine("Players online: " + SQL.OnlinePlayersCountSum);
        }
        public static void MainTextAppend(string s)
        {
            Gotoxy(FirstX[1]+1, FirstY[1] + LastLineCount);
            Console.WriteLine(s);
            Cakaj(s.Length * 20);
            LastLineCount++;
        }
        public static void UpdateUpperPart()
        {
            Gotoxy(FirstX[0], FirstY[0]);
            string output = "";
            for (int i = 0; i < LastX[0] - FirstX[0]; i++)
            {
                output += " ";
            }
            String[] moznosti = new String[] { "Vikingr", "Made by momoos", "Polar Bear Studios" };
            output = "";
            int SpaceLength = (LastX[0] - FirstX[0] - (moznosti[0].Length + moznosti[1].Length + moznosti[2].Length)) / 4;
            for (int j = 0; j < SpaceLength; j++)
            {
                output += " ";
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(output);
                Console.Write(moznosti[i]);
            }
        } //0
        public static void ClearMainPanel()
        {
            string output = "";
            for (int i = 0; i < LastX[1] - FirstX[1] + 1; i++)
            {
                output += " ";
            }
            for (int i = 0; i < LastY[1] - FirstY[1] + 1; i++)
            {
                Gotoxy(FirstX[1], i + FirstY[1]);
                Console.Write(output);
            }
        } //1
        public static void ClearStatsPanel()
        {
            string output = "";
            for (int i = 0; i < LastX[2] - FirstX[2] + 1; i++)
            {
                output += " ";
            }
            for (int i = 0; i < LastY[2] - FirstY[2] + 1; i++)
            {
                Gotoxy(FirstX[2], i + FirstY[2]);
                Console.Write(output);
            }
        } //2
        public static void ClearActionPanel()
        {
            string output = "";
            for (int i = 0; i < LastX[3] - FirstX[3] + 1; i++)
            {
                output += " ";
            }
            for (int i = 0; i < LastY[3] - FirstY[3] + 1; i++)
            {
                Gotoxy(FirstX[3], i + FirstY[3]);
                Console.Write(output);
            }
        } //3        

        public static void Inventory()
        {
            for (int i = 0; i < 16; i++)
            {
                if (i==0)
                {
                    Gotoxy(LastX[1] - 51, FirstY[1]);
                    Console.WriteLine("Currently wearing");
                }
                if (i == 8)
                {
                    Gotoxy(LastX[1] - 51, FirstY[1] + (i * 3)+1);
                    Console.WriteLine("Stored");
                }
                InventoryItem(i);
            }
            VypisanieAkcii.VypisAkcie("Inventory");
            RiesenieAkcii.VykonajAkciu("Inventory");
        }
        public static void InventoryItem(int i) 
        {
            
            
            if (i>7)
            {
                Gotoxy(LastX[1] - 51, FirstY[1] + (i * 3) + 2);
                Console.WriteLine("╔════════════════════════════════════════════════╗");//50
                Gotoxy(LastX[1] - 51, FirstY[1] + (i * 3) + 3);
                int tmp = i - 7;
                Console.WriteLine("║ " + tmp + ") " + itemy[i].Name + SpacesAndEnderInv(tmp.ToString().Length + 3 + itemy[i].Name.Length));
                Gotoxy(LastX[1] - 51, FirstY[1] + (i * 3) + 4);
                Console.WriteLine("╚════════════════════════════════════════════════╝");//50
            }
            else             
            {
                Gotoxy(LastX[1] - 51, FirstY[1] + (i * 3) + 1);
                Console.WriteLine("╔════════════════════════════════════════════════╗");//50
                Gotoxy(LastX[1] - 51, FirstY[1] + (i * 3) + 2); 
                Console.WriteLine("║ " + (i+1) + ") " + itemy[i].Name + SpacesAndEnderInv((i+1).ToString().Length + 3 + itemy[i].Name.Length));
                Gotoxy(LastX[1] - 51, FirstY[1] + (i * 3) + 3);
                Console.WriteLine("╚════════════════════════════════════════════════╝");//50
            }

            //"║ "
            //══════════════════════
        }
        public static string SpacesAndEnderInv(int lngth) 
        {
            string s="";
            for (int i = lngth; i < 48; i++)
            {
                s+= " ";
            }
            s += "║";
            return s;
        }
    }
}