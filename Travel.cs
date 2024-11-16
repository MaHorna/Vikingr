using System;
using static Vikingr.Stats;
using static Vikingr.Metody;
using static Vikingr.UpdateWindows;


namespace Vikingr
{
    class Travel
    {
        public static string[] LoadedTravelFile;
        public static void Traveling()
        {
            LoadedTravelFile[0] = "Aruna; Gierland 18";
            LoadedTravelFile[1] = "Gierland; Aruna 18,Moberg 19,Grimsnes 28";
            LoadedTravelFile[2] = "Grimsnes; Gierland 28,Ballara 22";
            LoadedTravelFile[3] = "Moberg; Gierland 19,Laugardalr 11,Siglunes 6";
            LoadedTravelFile[4] = "Laugardalr; Siglunes 15,Moberg 11";
            LoadedTravelFile[5] = "Siglunes; Moberg 6,Laugardalr 15,Axlarhagi 31";
            LoadedTravelFile[6] = "Skeio; Axlarhagi 44";
            LoadedTravelFile[7] = "Axlarhagi; Siglunes 31,Skeio 44,Gonguskarosa 26,Ballara 17";
            LoadedTravelFile[8] = "Ballara; Grimsnes 22,Axlarhagi 17,Gonguskarosa 16";
            LoadedTravelFile[9] = "Gonguskarosa; Ballara 16,Axlarhagi 26,Skalamyrr 9";
            LoadedTravelFile[10] = "Skalamyrr; Gonguskarosa 9,Booolfsskytja 12,Osomi 6,Iara 15,Husavik 20";
            LoadedTravelFile[11] = "Booolfsskytja; Skalamyrr 12,Boomooshraun 40";
            LoadedTravelFile[12] = "Boomooshraun; Booolfsskytja 40";
            LoadedTravelFile[13] = "Osomi; Skalamyrr 6,Iara 10";
            LoadedTravelFile[14] = "Iara; Skalamyrr 15,Osomi 10,Hofsfell 14";
            LoadedTravelFile[15] = "Husavik; Skalamyrr 20,Hofsfell 9,Holmslond 26";
            LoadedTravelFile[16] = "Holmslond; Husavik 26";
            LoadedTravelFile[17] = "Hofsfell; Iara 14,Husavik 9,Fellshverfi 12";
            LoadedTravelFile[18] = "Fellshverfi; Hofsfell 12,Hanatun 23";
            LoadedTravelFile[19] = "Hanatun; Fellshverfi 23";
            for (int i = 0; i < LoadedTravelFile.Length + 1; i++)
            {
                int pos = LoadedTravelFile[i].IndexOf(';');
                if (Town == LoadedTravelFile[i].Substring(0, pos))
                {
                    string[] s = LoadedTravelFile[i].Split(';');
                    string[] Destinations = s[1].Split(',');
                    for (int j = 0; j < Destinations.Length; j++)
                    {
                        MainTextAppend((j + 1) + ") " + Destinations[j] + " miles");

                    }
                    RiesenieAkcii.VykonajAkciu("GetNumber");
                    pos = Destinations[RiesenieAkcii.SetNumber - 1].IndexOf(" ");
                    MainTextAppend("You are traveling to " + Destinations[RiesenieAkcii.SetNumber - 1].Substring(0, pos));
                    MainTextAppend("It will take you a " + DDHHMM(Int32.Parse(Destinations[RiesenieAkcii.SetNumber - 1].Substring(pos + 1, Destinations[RiesenieAkcii.SetNumber - 1].Length - (pos + 1))) * 90) + " DD:HH:MM");
                    Town = Destinations[RiesenieAkcii.SetNumber - 1].Substring(0, pos);
                    Hodin = (int)Math.Round(Int32.Parse(Destinations[RiesenieAkcii.SetNumber - 1].Substring(pos + 1, Destinations[RiesenieAkcii.SetNumber - 1].Length - (pos + 1))) * 1.5);
                    VypisanieAkcii.VypisAkcie("1");
                    RiesenieAkcii.VykonajAkciu("1");
                    break;
                }
            }

        }
    }
}
