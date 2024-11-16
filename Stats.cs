using System;

namespace Vikingr
{
    class Stats
    {
        public static String Name;
        public static String Password;
        public static int Sila;//
        public static int Obrat;//
        public static int Vydrz;//
        public static int Chari;//
        public static int Intel;//

        public static int Obrana;//
        public static int Utok;//
        public static int Skore;//
        public static int Zlatky;//
        public static int Strieborne;//
        public static int Medene;//

        public static String Helma;//
        public static String Brnenie;//
        public static String Rukavice;//
        public static String Nohavice;//
        public static String Topanky;//
        public static String LavaR;//
        public static String PravaR;//
        public static String Doplnok;//

        public static int Hodin;//
        public static int Rokov;//
        public static int Mesiacov;//
        public static int Dni;//
        public static String Town;//

        public static int FightsCount;
        public static int WinCount;
        public static int LostCount;

        public static int Age()
        {
            int age = 0;
            if (Rokov < 4)
            {
                age = 1;
            }
            else if (Rokov < 11)
            {
                age = 2;
            }
            else if (Rokov < 16)
            {
                age = 3;
            }
            else if (Rokov < 50)
            {
                age = 4;
            }
            else if (Rokov < 70)
            {
                age = 5;
            }
            else if (Rokov < 100)
            {
                age = 6;
            }
            return age;
        }
        public static void VypocetRokovAMesiacov()
        {
            int tmp;
            if (Hodin > 24)
            {
                tmp = Hodin / 24;
                Hodin %= 24;
                Dni += tmp;
            }
            if (Dni > 30)
            {
                tmp = Dni / 30;
                Dni %= 30;
                Mesiacov += tmp;
            }
            if (Mesiacov > 12)
            {
                tmp = Mesiacov / 12;
                Mesiacov %= 12;
                Rokov += tmp;
            }
        }
        public static void CopperCoinInput(int copper) {
            Medene += copper;
            int tmp = Medene/10000;
            Zlatky += tmp;
            Medene -= tmp * 10000;
            tmp = Strieborne / 100;
            Strieborne += tmp;
            Medene -= tmp * 100;
        }
        public static string TimeOld() {
            string s = "";
            s = Rokov + " " + Mesiacov + " " + Dni + " " + Hodin;
            return s;        
        }
        public static void getTimeOld(string s)
        {
            string[] tmp = new string[] { };
            tmp = s.Split(' ');
            Rokov = Int32.Parse(tmp[0]);
            Mesiacov = Int32.Parse(tmp[1]);
            Dni = Int32.Parse(tmp[2]);
            Hodin = Int32.Parse(tmp[3]);
        }
        public static string StatsOut() {
            string s = "";
            s = Sila + " " + Obrat + " " + Vydrz + " " + Chari + " " + Intel;
            return s;
        }
        public static void getStats(string s)
        {
            string[] tmp = new string[] { };
            tmp = s.Split(' ');
            Sila = Int32.Parse(tmp[0]);
            Obrat = Int32.Parse(tmp[1]);
            Vydrz = Int32.Parse(tmp[2]);
            Chari = Int32.Parse(tmp[3]);
            Intel = Int32.Parse(tmp[4]);
        }
        public static string PlayersFightsWinrateOut()
        {
            string s = "";
            s = FightsCount + " " + WinCount + " " + LostCount;
            return s;
        }
        public static void getWinrate(string s)
        {
            string[] tmp = new string[] { };
            tmp = s.Split(' ');
            FightsCount = Int32.Parse(tmp[0]);
            WinCount = Int32.Parse(tmp[1]);
            LostCount = Int32.Parse(tmp[2]);
        }
    }
}
