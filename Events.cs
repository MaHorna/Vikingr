using System;
using static Vikingr.RiesenieAkcii;
using static Vikingr.Stats;
using static Vikingr.UpdateWindows;
using static Vikingr.VypisanieAkcii;

namespace Vikingr
{
    class Events
    {
        public static void Event()
        {
            //pridat naviazanosť na trening (ak sa hram s kamienkami - najdem mincu medzi kamienkami)
            Random rnd = new Random();
            Random rnd2 = new Random();
            int Chance = rnd.Next(5);
            if (Chance == 0) //stane sa event? - 20%  sanca
            {
                Chance = rnd2.Next(5);
                if (Chance != 0) //bude to event spojený z akciou alebo uplne random? - 80% šanca na to bzť spojený s akciou
                {
                    switch (LastAction)
                    {
                        case "2 1":
                            Chance = rnd.Next(6);
                            if (Chance == 0)
                            {
                                MainTextAppend("Ked si sa minule hral s paličkami");
                                MainTextAppend("Jednu z nich si zdvihol, no nemal si práve dobrú stabilitu");
                                MainTextAppend("Spadol si a zrazu si si uvedomil ako si trošku osprostel");
                                MainTextAppend("-1 Inteligencia");
                                Intel -= 1;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 1)
                            {
                                MainTextAppend("Ked si sa minule hral s paličkami");
                                MainTextAppend("Jednu z nich si zdvihol, no nemal si práve dobrú stabilitu");
                                MainTextAppend("Spadol si. Nabudúce si už dáš pozor");
                                MainTextAppend("+1 Inteligencia");
                                Intel += 1;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 2)
                            {
                                MainTextAppend("Ked si sa minule hral s paličkami");
                                MainTextAppend("Jednu z nich si zdvihol, a len tak z ničiho nič si ju hodil do neďalekého krovia");
                                MainTextAppend("Vtedy si pocítil tvoju silu");
                                MainTextAppend("+1 Sila");
                                Sila += 1;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 3)
                            {
                                MainTextAppend("Jeden podvečer si sa hral s paličkami, šermoval a podobne...");
                                MainTextAppend("Zrazu si zbadal obrovského potkana ako sa motá ani nie 10 lakťov od teba");
                                MainTextAppend("Potichu si zobral jednu z paličiek, pomaly kráčal k nemu...");
                                MainTextAppend("A rozmlátil si ho že z neho zostal len flak...");
                                MainTextAppend("+2 Sila");
                                Sila += 2;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 4)
                            {
                                MainTextAppend("Jeden podvečer si sa hral s paličkami, šermoval a podobne...");
                                MainTextAppend("Zrazu si zbadal obrovského potkana ako sa motá ani nie 10 lakťov od teba");
                                MainTextAppend("Potichu si zobral jednu z paličiek, namieril a hodil ako sekeru...");
                                MainTextAppend("úplne mimo");
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 5)
                            {
                                MainTextAppend("Jeden podvečer si sa hral s paličkami, šermoval a podobne...");
                                MainTextAppend("Zrazu si zbadal obrovského potkana ako sa motá ani nie 15 lakťov od teba");
                                MainTextAppend("Položil si malú paličku čo si mal v ruke, pomaly kráčal k nemu...");
                                MainTextAppend("Keď už si bol od neho možno 3 stopy od neho...");
                                MainTextAppend("Rýchlo si sa za ním načiahol... no on v poslednej chvíli začal utekať...");
                                MainTextAppend("Potkan kľučkuje ... No nakoniec ho chytíš... a pustíš ... na čo ti je predsa");
                                MainTextAppend("+3 Obratnosť");
                                Obrat += 3;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            break;
                        case "2 2":
                            Chance = rnd.Next(5);
                            if (Chance == 0)
                            {
                                MainTextAppend("Nahanal si sliepky a spadol");
                                MainTextAppend("Strašne ťa bolel členok");
                                MainTextAppend("+1 Mesiac");
                                Mesiacov += 1;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 1)
                            {
                                MainTextAppend("Jeden podvečer si nahaňal sliepky ako zvyčajne");
                                MainTextAppend("Jedna z nich na teba zaútočila ");
                                MainTextAppend("Po jej útoku máš jazvu na tvári. -1 Charizma");
                                Chari -= 1;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 2)
                            {
                                MainTextAppend("Nahaňal si sliepky ako zvyčajne");
                                MainTextAppend("Ako dospievaš už ti nevládzu unikať ako kedysi");
                                MainTextAppend("+2 Obratnosť +1 Výdrž");
                                Obrat += 2; Vydrz += 1;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 3)
                            {
                                MainTextAppend("Pri nahánani sliepok si pochopil");
                                MainTextAppend("Pochopil si anatomiu");
                                MainTextAppend("+1 Inteligencia");
                                Intel += 1;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            if (Chance == 4)
                            {
                                MainTextAppend("Strašne smrdíš od slepačincov");
                                MainTextAppend("-1 Charizma +1 Obratnosť");
                                Chari -= 1; Obrat += 1;
                                VypisAkcie("1");
                                VykonajAkciu("1");
                            }
                            break;
                        case " ":
                            break;
                        default:
                            break;
                    }
                }
                else { } //random event
            }
            else { MainTextAppend("Nič zvlášne sa nestalo"); }
            /*if ((Rokov < 5) && (n == 1))
            {
                MainTextAppend("Hral si sa vonku s kamienkami";
                MainTextAppend("Medzi kamienkami si našiel 1 medenú mincu";
                MainTextAppend("+1 Medenák";
                Medene -= 1;
                VypisAkcie("1");
                VykonajAkciu("1");
            }
            else goto random;*/

        }
    }
}
