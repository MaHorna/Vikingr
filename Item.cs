using System;
using static Vikingr.Stats;
namespace Vikingr
{

    public class Item
    {
        public static Item[] itemy = new Item[16];
        public string Name; //random name
        public int TypeOfItem;//sword , armour ....
        public int Value; //value in copper coins
        public int Durability;
        public double[] Multiplicators;
        public int[] Adders;
        public double AttackDamage;
        public double Armour;


        public Item(string name, int typeOfItem, int value, int durability, double[] multiplicators, int[] adders, double attackDamage, double armour)
        {
            this.Name = name;
            this.TypeOfItem = typeOfItem;
            this.Value = value;
            this.Durability = durability;
            this.Multiplicators = multiplicators;
            this.Adders = adders;
            this.AttackDamage = attackDamage;
            this.Armour = armour;
        }
        public static void GenItem()
        {
            double[] tmp1 = { 0.0, 0.0, 0.0, 0.0, 0.0 }; int[] tmp2 = { 0, 0, 0, 0, 0 };
            Item item = new Item("x", 0, 0, 0, tmp1, tmp2, 0, 0);
            for (int i = 0; i < 16; i++)
            {
                itemy[i] = item;
            }
        }
        public static void getItems(string s)
        {
            string[] tmp = new string[] { };
            tmp = s.Split(';');            
            for (int i = 0; i < 16; i++)//item parsing
            {
                string[] tmp2 = new string[] { };
                tmp2 = tmp[i].Split(',');
                Metody.Okno(tmp2.Length.ToString());
                itemy[i].Name = tmp2[0];
                itemy[i].TypeOfItem = Int32.Parse(tmp2[1]);
                itemy[i].Value = Int32.Parse(tmp2[2]);
                itemy[i].Durability = Int32.Parse(tmp2[3]);
                Metody.Okno(i.ToString());
                itemy[i].AttackDamage = Int32.Parse(tmp2[4]);
                itemy[i].Armour = Int32.Parse(tmp2[5]);
                itemy[i].Multiplicators[0] = Double.Parse(tmp2[6], System.Globalization.CultureInfo.InvariantCulture);
                itemy[i].Multiplicators[1] = Double.Parse(tmp2[7], System.Globalization.CultureInfo.InvariantCulture);
                itemy[i].Multiplicators[2] = Double.Parse(tmp2[8], System.Globalization.CultureInfo.InvariantCulture);
                itemy[i].Multiplicators[3] = Double.Parse(tmp2[9], System.Globalization.CultureInfo.InvariantCulture);
                itemy[i].Multiplicators[4] = Double.Parse(tmp2[10], System.Globalization.CultureInfo.InvariantCulture);
                itemy[i].Adders[0] = Int32.Parse(tmp2[11]);
                itemy[i].Adders[1] = Int32.Parse(tmp2[12]);
                itemy[i].Adders[2] = Int32.Parse(tmp2[13]);
                itemy[i].Adders[3] = Int32.Parse(tmp2[14]);
                itemy[i].Adders[4] = Int32.Parse(tmp2[15]);
            }
        }
        public static Double[] MultiplyStatsSumer = new Double[] { 0.0, 0.0, 0.0, 0.0, 0.0 };
        public static int[] AddStatsSumer = new int[] { 0, 0, 0, 0, 0 };
        public static double AttackDamageSum;
        public static double ArmorSum;
        public static void ItemImplementation()
        {
            Helma = itemy[0].Name;
            Brnenie = itemy[1].Name;
            Rukavice = itemy[2].Name;
            Nohavice = itemy[3].Name;
            Topanky = itemy[4].Name;
            LavaR = itemy[5].Name;
            PravaR = itemy[6].Name;
            Doplnok = itemy[7].Name;
            MultiplyStatsSumer = new Double[] { 0.0, 0.0, 0.0, 0.0, 0.0 };
            AddStatsSumer = new int[] { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    MultiplyStatsSumer[j] += itemy[i].Multiplicators[j];
                    AddStatsSumer[j] += itemy[i].Adders[j];
                    AttackDamageSum += itemy[i].AttackDamage;
                    ArmorSum += itemy[i].Armour;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (MultiplyStatsSumer[i] == 0)
                {
                    MultiplyStatsSumer[i] = 1;
                }
            }

        }
    }
}
