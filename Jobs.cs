using System;
using System.Collections.Generic;
using System.Text;
using static Vikingr.Stats;
using static Vikingr.RiesenieAkcii;
using static Vikingr.Metody;

namespace Vikingr
{
    class Jobs
    {
        public static void LocalJobsMain()
        {
            int tmp1 = UI.FirstX[3] + 1;
            int tmp2 = UI.FirstY[3] + 1;
            string jobstring = "";
            switch (Town)
            {

                //1pohraničné mesto - straženie hranic , stavanie opevnení
                //2hlavné mesto
                //3pobrežné mesto - práca v skladisku, pomoc na rybárskej lodi
                //4rolnícke mesto
                //5banícka dedina - práca v bani
                //6dobytkárska dedina - pasenie dobytka
                //7mesto 
                //8velká dedina

                case "Aruna":
                    break;
                case "Gierland":
                    break;
                case "Grimsnes":
                    break;
                case "Moberg":
                    break;
                case "Laugardalr":
                    break;
                case "Siglunes":
                    break;
                case "Skeio":
                    break;
                case "Axlarhagi":
                    break;
                case "Ballara":
                    break;
                case "Skalamyrr":
                    break;
                case "Gonguskarosa":
                    break;
                case "Booolfsskytja":
                    break;
                case "Boomooshraun":
                    break;
                case "Osomi":
                    break;
                case "Iara":
                    break;
                case "Husavik":
                    break;
                case "Holmslond":
                    break;
                case "Hofsfell":
                    break;
                case "Fellshverfi":
                    break;
                case "Hanatun":
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Help the farmer - 6C per hour");

                    if (Sila > 300)
                    {
                        Gotoxy(tmp1, tmp2 + 1);
                        Console.WriteLine("1) Help to build the fortifications - 1S per hour");
                    }
                    if (Sila > 600)
                    {
                        Gotoxy(tmp1, tmp2 + 2);
                        Console.WriteLine("1) Guard the border - 1S and 6C per hour");
                    }
                    break;
                default:
                    Okno("You seem to be in nonexistent town. Report this to the devs");
                    break;
            }
            ShowLocalJobs(jobstring); 
        }
        private static void ShowLocalJobs(string jobstring) { 
        }
        public static void PerformLocalJob()
        {
            string pressedkey = GetPressedKey();
            switch (Town)
            {
                case "Aruna":
                    switch (pressedkey)
                    {
                        case "1":

                        default:
                            break;
                    }
                    break;
                case "Gierland":
                    break;
                case "Grimsnes":
                    break;
                case "Moberg":
                    break;
                case "Laugardalr":
                    break;
                case "Siglunes":
                    break;
                case "Skeio":
                    break;
                case "Axlarhagi":
                    break;
                case "Ballara":
                    break;
                case "Skalamyrr":
                    break;
                case "Gonguskarosa":
                    break;
                case "Booolfsskytja":
                    break;
                case "Boomooshraun":
                    break;
                case "Osomi":
                    break;
                case "Iara":
                    break;
                case "Husavik":
                    break;
                case "Holmslond":
                    break;
                case "Hofsfell":
                    break;
                case "Fellshverfi":
                    break;
                case "Hanatun":
                    break;
                default: Okno("You seem to be in nonexistent town. Report this to the devs");
                    break;
            }
        }
    }
}
