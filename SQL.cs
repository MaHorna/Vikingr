using MySql.Data.MySqlClient;
using System;
using static Vikingr.Metody;
using static Vikingr.Stats;
using static Vikingr.UI;
using static Vikingr.Item;

namespace Vikingr
{
    class SQL
    {
        public static string testName;
        public static string testPassword;
        public static void Login()
            
        {//╬  ═  ╠   ╦   ╩  ╔  ╚  ╝  ║  ╣ ╗
        
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 10);            
            Console.WriteLine("╔════════════════════════╗");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 11);
            Console.WriteLine("║   Login and Register   ║");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 12);
            Console.WriteLine("║          Name          ║");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 13);
            Console.WriteLine("║ ╔════════════════════╗ ║");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 14);
            Console.WriteLine("║ ║                    ║ ║");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 15);
            Console.WriteLine("║ ╚════════════════════╝ ║");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 16);
            Console.WriteLine("║     Write and ENTER    ║");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 17);
            Console.WriteLine("╚════════════════════════╝");            
        tmp:
            Gotoxy(((LastX[1] - FirstX[1]) / 2) + 4, FirstY[1] + 14);
            string s = Console.ReadLine();
            if (s.Length > 20)
            {
                Okno("Name too long (max. 20 characters)");
                Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 14);
                Console.WriteLine("║ ║                    ║ ║                   ");
                goto tmp;
            }
            else
            {
                tmp2:
                testName = s;
                Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 12);
                Console.WriteLine("║        Password        ║");
                Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 14);
                Console.WriteLine("║ ║                    ║ ║");
                Gotoxy(((LastX[1] - FirstX[1]) / 2)+4, FirstY[1] + 14);
                s = Console.ReadLine();
                if (s.Length > 20)
                {
                    Okno("Password too long (max. 20 characters)");
                    Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 14);
                    Console.WriteLine("║ ║                    ║ ║");
                    goto tmp2;
                }
                else
                {
                    testPassword = s;
                    if (TestLogin(testName, testPassword))
                    {
                        LoadOnline();
                    }
                    else
                    {
                        VypisanieAkcii.VypisAkcie("LoginMissOrRegister");
                        RiesenieAkcii.VykonajAkciu("LoginMissOrRegister");
                    }
                }
            }
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 10);
            Console.WriteLine("                          ");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 11);
            Console.WriteLine("                          ");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 12);
            Console.WriteLine("                          ");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 13);
            Console.WriteLine("                          ");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 14);
            Console.WriteLine("                          ");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 15);
            Console.WriteLine("                          ");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 16);
            Console.WriteLine("                          ");
            Gotoxy((LastX[1] - FirstX[1]) / 2, FirstY[1] + 17);
            Console.WriteLine("                          ");
        }
        public static void Register()
        {
            string connectionString = "SERVER=remotemysql.com; PORT = 3306;DATABASE=kiK5nbYI5v;UID=kiK5nbYI5v;PASSWORD=QYFDK1NV3b;";
            MySqlConnection mycon = new MySqlConnection(connectionString);            
            OknoCakanieNaServer("Creating profile...", mycon);
            var sql = "INSERT INTO `PlayerList` (`ID`, `Name`, `Password`, `Town`, `TimeOld`, `LastTimePlayed`, `Items`, `Score`, `Stats`, `Online`, `PlayerFightsWinrate`) VALUES (NULL, '"+ testName +"', '"+ testPassword +"', '"+ Town +"', '0 0 0 0', '0 0 0000 00 00', '_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0\r\n_ 0 0 0 0\r\n1 1 1 1 1\r\n0 0 0 0 0', '0', '0 0 0 0 0', '1', '0 0 0');";
            var cmd = new MySqlCommand(sql, mycon);
            var reader = cmd.ExecuteReader();
            mycon.Close();

        }
        public static bool TestLogin(string testName, string testPassword) {
            string connectionString = "SERVER=remotemysql.com; PORT = 3306;DATABASE=kiK5nbYI5v;UID=kiK5nbYI5v;PASSWORD=QYFDK1NV3b;";
            MySqlConnection mycon = new MySqlConnection(connectionString);
            OknoCakanieNaServer("Checking for profile...", mycon);
            var sql = "SELECT Name, Password FROM PlayerList";
            var cmd = new MySqlCommand(sql, mycon);
            var reader = cmd.ExecuteReader();
            bool result=false;
            while (reader.Read())
            {
                if ((string)reader["Name"] == testName)
                {
                    if ((string)reader["Password"] == testPassword)
                    {
                         result = true;
                    }
                    else {result = false; }
                }
                else {  result = false; }
            }
            mycon.Close();
            return result;
        }

        public static void LoadOnline()
        {
            string connectionString = "SERVER=remotemysql.com; PORT = 3306;DATABASE=kiK5nbYI5v;UID=kiK5nbYI5v;PASSWORD=QYFDK1NV3b;";
            MySqlConnection mycon = new MySqlConnection(connectionString);            
            OknoCakanieNaServer("Loading profile...", mycon);
            var sql = "SELECT * FROM PlayerList WHERE Name='" + testName + "' AND Password='" + testPassword + "'";
            var cmd = new MySqlCommand(sql, mycon);
            var reader = cmd.ExecuteReader();
            reader.Read();
            Town = (string)reader["Town"];
            getTimeOld((string)reader["TimeOld"]);
            Item.getItems((string)reader["Items"]);
            Skore = (int)reader["Score"];
            getStats((string)reader["Stats"]);
            getWinrate((string)reader["PlayerFightsWinrate"]);
            mycon.Close();
        }
        public static void UpdateOnline()
        {
            string connectionString = "SERVER=remotemysql.com; PORT = 3306;DATABASE=kiK5nbYI5v;UID=kiK5nbYI5v;PASSWORD=QYFDK1NV3b;";
            MySqlConnection mycon = new MySqlConnection(connectionString);
            OknoCakanieNaServer("Saving profile...", mycon);
            string itemoutput = "";
            for (int i = 0; i < 16; i++)
            {
                itemoutput +=itemy[i].Name;
                itemoutput += "," + itemy[i].TypeOfItem;
                itemoutput += "," + itemy[i].Value;
                itemoutput += "," + itemy[i].Durability;
                itemoutput += "," + itemy[i].AttackDamage;
                itemoutput += "," + itemy[i].Armour;
                itemoutput += "," + itemy[i].Multiplicators[0];
                itemoutput += "," + itemy[i].Multiplicators[1];
                itemoutput += "," + itemy[i].Multiplicators[2];
                itemoutput += "," + itemy[i].Multiplicators[3];
                itemoutput += "," + itemy[i].Multiplicators[4];
                itemoutput += "," + itemy[i].Adders[0];
                itemoutput += "," + itemy[i].Adders[1];
                itemoutput += "," + itemy[i].Adders[2];
                itemoutput += "," + itemy[i].Adders[3];
                itemoutput += "," + itemy[i].Adders[4] + ";";
            }
            string day = DateTime.Now.ToString("d M yyyy H m");
            var sql = "UPDATE PlayerList SET Town='" + Town + "', TimeOld='" + TimeOld() + "', LastTimePlayed='" + day + "', Items='" + itemoutput + "', Score = " + Skore + ", Stats = '" + StatsOut() + "' , PlayerFightsWinrate = '" + PlayersFightsWinrateOut() + "' , Online = 1" + " WHERE Name='" + testName + "' AND Password='" + testPassword + "'"; 
            var cmd = new MySqlCommand(sql, mycon);
            cmd.ExecuteNonQuery();
            mycon.Close();
        }
        public static void CountOnlinePlayers() {
            string connectionString = "SERVER=remotemysql.com; PORT = 3306;DATABASE=kiK5nbYI5v;UID=kiK5nbYI5v;PASSWORD=QYFDK1NV3b;";
            MySqlConnection mycon = new MySqlConnection(connectionString);
            mycon.Open();
            var sql = "SELECT * FROM PlayerList WHERE Online=1";
            var cmd = new MySqlCommand(sql, mycon);
            var reader = cmd.ExecuteReader();
            int sum = 0;
            while (reader.Read())
            {
                sum++;
            }
            mycon.Close();
            OnlinePlayersCountSum = sum;
        }
        public static int OnlinePlayersCountSum;
    }
}
