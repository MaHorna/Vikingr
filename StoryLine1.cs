using System;
using static Vikingr.Stats;
using static Vikingr.UpdateWindows;


namespace Vikingr
{
    class StoryLine1
    {
        public static String Priezvysko;
        public static String Meno;
        public static void Narodenie()
        {
            Random random = new Random();
            //práca rodičov , vek rodičov , osud 
            string[] povolanieOtca = new string[] { "rybár", "bojovník", "jarl", "obchodník", "remeselník" };
            string[] povolanieMatky = new string[] { "bojovníčka", "žena v domácnosti", "nepracujúca", "slúžka", "kuchárka v hostinci" };
            int povolanieOtcai = random.Next(5); int povolanieMatkyi = random.Next(5);
            Boolean[] chlap = new Boolean[] { true, false };
            Boolean chlapec = chlap[random.Next(2)];
            string[] chlapci = new string[] { "Bjørn", "Eirik", "Geir", "Gunnar", "Harald", "Håkon", "Ivar", "Knut", "Leif", "Magnus", "Olav", "Rolf", "Sigurd", "Steinar", "Torstein", "Ulf", "Valdemar", "Vidar" };
            string[] dievcata = new string[] { "Arne", "Gisle", "Inge", "Snorre", "Trygve", "Yngve" };
            string[] priezvy = new string[] { "AGNARSSON", "AHLBERG", "ÅKERMAN", "BECK", "BERGFALK", "EINARSSON", "EK", "LOTHBROK", "ALGAARD", "KNUTSSON", "LÅNG", "STENDAHL", "STIGSSON", "SVENSON", "VOLLAN", "WOLFF", "WINTHER", "THORN", "OLSON", "HJORT", "HULT" };
            string[] mesto = new string[] { "Ballara", "Moberg", "Boomooshraun", "Fellshverfi", "Iara", "Skeio",
                "Booolfs skytja", "Axlarhagi", "Hanatun", "Geirland", "Hofsfell", "Laugardalr", "Grimsnes", "Gonguskarosa",
                "Skalamyrr", "Husavik", "Holmslond", "Siglunes", "Osomi", "Aruna" };
            int[] vzd = new int[] { 25, 72, 52, 41, 15, 79, 12, 35, 64, 75, 29, 81, 47, 9, 0, 20, 46, 66, 6, 93 };
            int rnd = random.Next(20);
            string mesto1 = mesto[rnd];
            int mestovzd = vzd[rnd];
            Town = mesto1;
            Priezvysko = priezvy[random.Next(21)];
            int oteczije = random.Next(10); bool matka; bool otec; int matkazije = random.Next(10); int tmpsanca;
            if (matkazije < 4)
            {
                matka = false;
            }
            else { matka = true; }
            if (povolanieOtcai == 1)
            {
                tmpsanca = 4;
            }
            else { tmpsanca = 1; }
            if (oteczije < tmpsanca)
            {
                otec = false;
            }
            else { otec = true; }
            if (chlapec)
            {
                Meno = chlapci[random.Next(18)];

            }
            else
            {
                Meno = dievcata[random.Next(6)];
            }
            string stavrodicov;
            if (otec && matka)
            {
                stavrodicov = "Obaja tvoji rodičia žijú.";
            }
            else if (otec & (!matka))
            {
                stavrodicov = "Otec žije no matka ti zomrela pri pôrode.";
            }
            else if (matka && (!otec) && (povolanieOtcai == 1))
            {
                stavrodicov = "Matka žije no otec sa vybral pár mesiacov pred tvojím narodením na nájazd a už sa nevrátil.";
            }
            else if (matka && (!otec) && (povolanieOtcai == 3))
            {
                stavrodicov = "Matka žije no otec sa vybral pár mesiacov pred tvojím narodením na obchodnú cestu a už sa nevrátil.";
            }
            else if (matka && (!otec))
            {
                stavrodicov = "Matka žije no otec zomrel nejakou nešťastnou náhodou.";
            }
            else if (!matka && !otec)
            {
                stavrodicov = "Tvaja matka ani tvoj otec nežijú.";
            }
            else { stavrodicov = "nejaka blbosť sa stala - opraviť chybu zo stavom rodičov BUG !!!!"; }
            string povolotca; string povolmatky;

            if (otec)
            {
                povolotca = "Tvoj otec je " + povolanieOtca[povolanieOtcai] + ". ";
            }
            else { povolotca = "Tvoj otec bol " + povolanieOtca[povolanieOtcai] + ". "; }
            if (matka)
            {
                povolmatky = "Tvoja matka je " + povolanieMatky[povolanieMatkyi] + ". ";
            }
            else { povolmatky = "Tvoja matka bola " + povolanieMatky[povolanieMatkyi] + ". "; }
            MainTextAppend(Meno + " " + Priezvysko + " - meno ti dala matka a priezvysko máš po otcovy. ");
            MainTextAppend(stavrodicov + povolotca + povolmatky);
            if (mesto1 == "Skalamyrr")
            {
                MainTextAppend("Narodil si sa v meste Skalamyrr. V hlavnom meste tohto Jarlstva");
            }
            else
            {
                MainTextAppend("Narodil si sa v dedine " + mesto1 + ". Hlavné mesto tohto Jarlstva je vzdialené " + mestovzd + " námorných míl.");
            }
            VypisanieAkcii.VypisAkcie("1");
            RiesenieAkcii.VykonajAkciu("1");
        }
    }
}
