using System;
using WindowsInput;
using WindowsInput.Native;
using static TrueVikingr.Metody;
namespace TrueVikingr
{
    class UI
    {
        public static int[] FirstX = new int[] { 0, 0, 0, 0, 0 };
        public static int[] FirstY = new int[] { 0, 0, 0, 0, 0 };
        public static int[] LastX = new int[] { 0, 0, 0, 0, 0 };
        public static int[] LastY = new int[] { 0, 0, 0, 0, 0 };
        public static int maxsirka = Console.LargestWindowWidth - 3;
        public static int maxvyska = Console.LargestWindowHeight - 1;
        public static void ZapnutieHry()
        {
            int n = 1;
            InputSimulator sim = new InputSimulator(); //nastavenie konzoly
            sim.Keyboard.KeyDown(VirtualKeyCode.LWIN);
            sim.Keyboard.KeyPress(VirtualKeyCode.UP);
            sim.Keyboard.KeyUp(VirtualKeyCode.LWIN);
            Console.SetWindowSize(maxsirka, maxvyska);
            string medzery = "";
            string medzery2 = "";
            for (int i = 0; i < (maxsirka - 16) / 2; i++)
            {
                medzery += " ";
            }
            for (int i = 0; i < (maxsirka - 34) / 2; i++)
            {
                medzery2 += " ";
            }
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine();
                Cakaj(n);
            }
            Console.WriteLine(medzery + "╔══════════════╗");
            Cakaj(n);
            Console.WriteLine(medzery + "║ True Vikingr ║");
            Cakaj(n);
            Console.WriteLine(medzery + "╚══════════════╝");
            Cakaj(n);
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine();
                Cakaj(n);
            }
            Console.WriteLine(medzery2 + "===<Made by Polar Bear Studios>===");
            Cakaj(n);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine();
                Cakaj(n);
            }
        }
        public static void Ohranicenia()
        {
            //0- menu up , 1 main big left, 2 stats right, 3 actions down left, 4 time and score down right

            Boolean[] FirstTime = new Boolean[] { true, true, true, true, true };
            //╬  ═  ╠   ╦   ╩  ╔  ╚  ╝  ║  ╣ ╗
            for (int i = 0; i < maxvyska; i++)
            {
                for (int j = 0; j < maxsirka - 1; j++)
                {
                    float tmp1 = maxvyska / 10;
                    float tmp2 = maxsirka / 5;
                    if ((i == 0) && (j == 0))
                    {
                        Console.Write("╔");
                    }
                    else if ((i == 2) && (j == (maxsirka - 1) - Math.Round(tmp2)))
                    {
                        Console.Write("╦");
                    }
                    else if ((i == (maxvyska - 3) - Math.Round(tmp1)) && (j == (maxsirka - 1) - Math.Round(tmp2)))
                    {
                        Console.Write("╬");
                    }
                    else if ((i == maxvyska - 1) && (j == (maxsirka - 1) - Math.Round(tmp2)))
                    {
                        Console.Write("╩");
                    }
                    else if (((i == 0) || (i == 2) || (i == maxvyska - 1) || (i == (maxvyska - 3) - Math.Round(tmp1))) && (j < maxsirka - 2) && (j > 0))
                    {
                        Console.Write("═");
                    }
                    else if ((i == 0) && (j == maxsirka - 2))
                    {
                        Console.Write("╗");
                    }
                    else if ((i == 1) && (j < maxsirka - 2) && (j > 0))
                    { //menu
                        if ((LastY[0] < i) || (LastX[0] < j))
                        {
                            LastY[0] = i;
                            LastX[0] = j;
                        }
                        if (FirstTime[0])
                        {
                            FirstY[0] = i;
                            FirstX[0] = j;
                            FirstTime[0] = false;
                        }
                        Console.Write(" ");
                    }
                    else if (((i == 2) || ((i == (maxvyska - 3) - Math.Round(tmp1)))) && (j == 0))
                    {
                        Console.Write("╠");
                    }
                    else if ((i == 2) || ((i == (maxvyska - 3) - Math.Round(tmp1))) && (j == maxsirka - 2))
                    {
                        Console.Write("╣");
                    }
                    else if ((i == maxvyska - 1) && (j == 0))
                    {
                        Console.Write("╚");
                    }
                    else if ((i == maxvyska - 1) && (j == maxsirka - 2))
                    {
                        Console.Write("╝");
                    }
                    else if ((i > 2) && (i < (maxvyska - 3) - Math.Round(tmp1)) && (j < (maxsirka - 1) - Math.Round(tmp2)) && (j > 0))
                    { //main big
                        if ((LastY[1] < i) || (LastX[1] < j))
                        {
                            LastY[1] = i;
                            LastX[1] = j;
                        }
                        if (FirstTime[1])
                        {
                            FirstY[1] = i;
                            FirstX[1] = j;
                            FirstTime[1] = false;
                        }
                        Console.Write(" ");
                    }
                    else if ((i > 2) && (i < maxvyska - 3 - Math.Round(tmp1)) && (j < maxsirka - 2) && (j > maxsirka - 1 - (Math.Round(tmp2))))
                    { //stats
                        if ((LastY[2] < i) || (LastX[2] < j))
                        {
                            LastY[2] = i;
                            LastX[2] = j;
                        }
                        if (FirstTime[2])
                        {
                            FirstY[2] = i;
                            FirstX[2] = j;
                            FirstTime[2] = false;
                        }
                        Console.Write(" ");
                    }
                    else if ((i > (maxvyska - 3) - Math.Round(tmp1)) && (i < maxvyska - 1) && (j < maxsirka - 2) && (j > (maxsirka - 1) - (Math.Round(tmp2))))
                    { //time and score
                        if ((LastY[4] < i) || (LastX[4] < j))
                        {
                            LastY[4] = i;
                            LastX[4] = j;
                        }
                        if (FirstTime[4])
                        {
                            FirstY[4] = i;
                            FirstX[4] = j;
                            FirstTime[4] = false;
                        }
                        Console.Write(" ");
                    }
                    else if ((i > (maxvyska - 3) - Math.Round(tmp1)) && (i < maxvyska - 1) && (j > 0) && (j < (maxsirka - 1) - (Math.Round(tmp2))))
                    { //actions
                        if ((LastY[3] < i) || (LastX[3] < j))
                        {
                            LastY[3] = i;
                            LastX[3] = j;
                        }
                        if (FirstTime[3])
                        {
                            FirstY[3] = i;
                            FirstX[3] = j;
                            FirstTime[3] = false;
                        }
                        Console.Write(" ");
                    }
                    else { Console.Write("║"); }
                }
                if (i != maxvyska - 1)
                {
                    Console.WriteLine();
                }
            }
        }
        public static void MapWrite()
        {
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 0);
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 1);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ / /   ░░░░░░░░▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▓▓▒▓▓▓▓▒▓▓▒▒░░░         ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 2);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ / /  ░░░░▒▒▒▒▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒░░░░░░ /        ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 3);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ / /  ░░░▒▒▒▒▓▓▓▓▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒░░░░░   _/         ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 4);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ Aruna / ■  ░░░▒▒▒▒▓▓▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ___/       ░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 5);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ /   \\  ░░░▒▒▒▒▓▒▒▒▒░░░░         __       ░░░░░░   _______/       ░░░░░▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 6);
            Console.WriteLine("║ ~ ~ ~ ~ ~_~ ~ ~ |     \\   ░░░░░░░░░░░ Moberg ___/  \\__■___________/         ░░░░░░▒▒▓▓▓▓▓▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 7);
            Console.WriteLine("║~ ~ ~ ~ ~/ \\~ ~ ~\\____  \\_       _________██_/    __/ Laugardalr     ░░░░░░░▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 8);
            Console.WriteLine("║ ~ ~ ~ ~ \\_/  Gierland \\  \\█____/ ░░      /  ____/          ░░░░░░░░▒▒▒▒▒▓▓▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 9);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ _/ _/    ░░░░░     /__/            ░░░░░░░▒▒▒▒▒▒▒▓▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 10);
            Console.WriteLine("║ ~ ~ /\\~ ~ ~ ~ ~ ~ ~_/ _/  ░░░░░░      ■/ Siglunes    ░░░░░░░▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 11);
            Console.WriteLine("║~ ~ / / ~ ~ ~ ~ ~ _/ _/  ░░▒░░░░      /             ░░░░░░▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 12);
            Console.WriteLine("║ ~ ~\\/ ~ ~ ~ ~ ~_/ _/ ░░░▒▒▒░░░      /           ░░░░░▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 13);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~/  / ░░░▒▒▒░░░       /         ░░░▒▒▒▒▒▒▒▓▓▓▒▓▓▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 14);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~/  / ░░▒▓▒▒░░        /     ░░▒▒░░░░░░░░░░▒▒▒▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒░░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 15);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~/  / ░░▒▓▒▒░░        /   ░░░░░░░░░░ Skeio ░░░░░░▒▒▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒░░░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 16);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ \\▄/ ░░▒▒▓▒▒░░       /  ░░░░  _________■    ░░░░░▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒▒▒▒▒░░░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 17);
            Console.WriteLine("║~ ~ Grimsnes / \\  ░░▒▒▒░░     __/________/             ░░░░▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 18);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ \\  \\__░░▒░░    ██ Axlarhagi    ░░░░░░░░░░░▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒▒░░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 19);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ \\___ \\░░░    /             ░░░░░░░░▒▒▒▒▓▓▒▒▒▒▓▓▒▒▓▓▓▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▓▓▓▒▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 20);
            Console.WriteLine("║ ~ ~ /\\~ ~ ~ ~ ~ ~\\ \\_____/|          ░░░░░░░▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 21);
            Console.WriteLine("║~ ~ ~\\/ ~  Ballara \\▀\\     |       ░░░░░░▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 22);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~\\_\\___/     ░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 23);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \\__ \\  ░░░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░        ░░░░░░░░░░░░░░▒▒▒▒▒▒▓▓▓▓▓▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 24);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~/ /_\\____ Booolfs skytja  ________________▄           ░░░░░▒▒▓▓▓▓▓║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 25);
            Console.WriteLine("║ ~ ~ ~ ~ ~  Gonguskarosa \\▀  ___  \\   ____▄_______/                         ░░░░░░░░░▒▒▓▓▓▓║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 26);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \\_/~ ~\\ ▄▄ /             ░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▓▓▓▓▓▓▓▓▓▓║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 27);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ Skalamyrr ████   ░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 28);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~\\/ ~ ~ ~ ~/     __/    \\           ░░░░░░░░░░░░░░░░░░░░░░░░     ░░░░▒▒▓▓▓║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 29);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~  Osomi /■____/  ░░░   \\  Husavik  _____ Holmslond              ░░░▒▓▓▓▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 30);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \\_    \\   ░░░░  \\___▄_____/     \\____▄           ░░░░░░░░▒▒▓▓▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 31);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~\\___ \\   ░░░░    /      ░░░░░░░░░        ░░░░░░░░░░▒▒▒▓▓▒▒▒▒▒▒║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 32);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  Iara \\▀\\__________\\    ░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▓▓▒▓▒▒▒▒▒▒░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 33);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \\__      __  \\      ░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 34);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \\____/~ \\ ■\\        ░░░░░░░░░░▒▒▒▒▒▓▓▒▒▒▒▒▒▒░░░░░░░░  ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 35);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ Hofsfell /   \\           ░░░░░░▒▒▒▒▓▓▒▒▒▒░░░░░░░       ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 36);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \\___ |__       ░░░░░░▒▒▒▒▒▒▒▒▒░░░░░           ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 37);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  Fellshverfi \\■_ \\    ░░░░░▒▒▒▒▓▓▒▒▒▒▒░░░              ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 38);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~\\ \\  ░░░░▒▒▓▒▒▒▒▒▒▒░░░        _________║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 39);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~\\ \\ ░░░▒▒▓▒▒▒▒▒░░░     _____/         ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 40);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~\\ \\ ░░░▒▒▓▒▒▒▒▒░░░     _____/         ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 41);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~\\ \\  ░░▒▒▒▒░░░ ______/               ║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 42);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ / |___ ░░░ ___/             ░░░░░░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 43);
            Console.WriteLine("║ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  Hanatun \\█__  \\___/             ░░░░░░░░░░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 44);
            Console.WriteLine("║~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ \\___         ░░░░░░░░░░░░░░░░░░░░║");
            Gotoxy(UI.FirstX[1] + 3, UI.FirstY[1] + 2 + 45);
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
