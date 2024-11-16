using System;
using static Vikingr.UI;

namespace Vikingr
{
    public class Metody
    {
        public static void Gotoxy(int x, int y) => Console.SetCursorPosition(x, y);
        public static void Ckj() { Console.ReadLine(); }
        public static void Clrscr() { Console.Clear(); }
        public static void Cakaj(int n) { System.Threading.Thread.Sleep(n); }
        public static void NevhodnyInput()
        {
            Gotoxy(90, 20);
            Console.WriteLine("╔════════════════╗");
            Gotoxy(90, 21);
            Console.WriteLine("║ Nevhodny INPUT ║");
            Gotoxy(90, 22);
            Console.WriteLine("╚════════════════╝");
            Cakaj(1000);
            Gotoxy(90, 20);
            Console.WriteLine("                  ");
            Gotoxy(90, 21);
            Console.WriteLine("                  ");
            Gotoxy(90, 22);
            Console.WriteLine("                  ");
        }
        public static void Okno(string Vypis)
        {
            int n = (maxsirka - Vypis.Length) / 2;
            string dlzka1 = "";
            string dlzka2 = "";
            for (int i = 0; i < Vypis.Length; i++)
            {
                dlzka1 += "═";
                dlzka2 += " ";
            }
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 19);
            Console.WriteLine("╔═{0}═╗", dlzka1);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 20);
            Console.WriteLine("║ {0} ║", Vypis);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 21);
            Console.WriteLine("╚═{0}═╝", dlzka1);
            Cakaj(Vypis.Length * 75);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 19);
            Console.WriteLine("  {0}  ", dlzka2);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 20);
            Console.WriteLine("  {0}  ", dlzka2);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 21);
            Console.WriteLine("  {0}  ", dlzka2);

        }
        public static void OknoCakanieNaServer(string Vypis, MySql.Data.MySqlClient.MySqlConnection conn)
        {
            
            int n = (maxsirka - Vypis.Length) / 2;
            string dlzka1 = "";
            string dlzka2 = "";
            for (int i = 0; i < Vypis.Length; i++)
            {
                dlzka1 += "═";
                dlzka2 += " ";
            }
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 19);
            Console.WriteLine("╔═{0}═╗", dlzka1);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 20);
            Console.WriteLine("║ {0} ║", Vypis);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 21);
            Console.WriteLine("╚═{0}═╝", dlzka1);
            conn.Open();
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 19);
            Console.WriteLine("  {0}  ", dlzka2);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 20);
            Console.WriteLine("  {0}  ", dlzka2);
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 21);
            Console.WriteLine("  {0}  ", dlzka2);
        }


        public static int RandomTimeMonth()
        {
            Random random = new Random();
            return random.Next(20) + 20;
        }
        public static String DDHHMM(int n) {
            string s = "";
            
            if (n/1440<10)
            {
                s = "0" + (n / 1440).ToString();
            }
            else { s = (n / 1440).ToString(); }
            s += ":";
            n = n - ((n / 1440) * 1440);


            if (n / 60 < 10)
            {
                s = "0" + (n / 60).ToString();
            }
            else { s = (n / 60).ToString(); }
            s += ":";
            n = n - ((n / 60) * 60);
            s += n % 60;
            return s;        
        }
    }
}