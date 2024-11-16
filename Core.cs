using System;
//using static Vikingr.FileHandle;
using static Vikingr.Item;
using static Vikingr.Metody;
using static Vikingr.RiesenieAkcii;
using static Vikingr.SQL;
using static Vikingr.Stats;
using static Vikingr.StoryLine1;
using static Vikingr.UI;
using static Vikingr.UpdateWindows;
using static Vikingr.VypisanieAkcii;

namespace Vikingr
{
    class Core
    {
        static void Main()
        {
            Console.Title = "Vikingr made by Momoos";            
            ZapnutieHry(); //intro animacia
            GenItem(); //tmp itemy aby nehadzalo error
            Clrscr(); //vycisti obrazovku            
            Ohranicenia(); //nakresli UI
            Login();
            ItemImplementation();
            while (Rokov < 100)
            {
                UpdateUpperPart();
                //Event();
                VypisAkcie("main");
                VykonajAkciu("main");
                UpdateTandS();
                UpdateStats();
                UpdateOnline();
            }           
            Ckj();
        }
    }
}
