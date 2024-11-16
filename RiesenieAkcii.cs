using System;
using static Vikingr.UI;
using static Vikingr.Metody;
using static Vikingr.Shop;
using static Vikingr.SQL;
using static Vikingr.Stats;
using static Vikingr.UpdateWindows;
using static Vikingr.VypisanieAkcii;
using static Vikingr.Item;
using static Vikingr.Travel;

namespace Vikingr
{
    class RiesenieAkcii
    {
        public static string GetPressedKey()
        {
            ConsoleKeyInfo cki;
            String getinput;
            do
            {
                while (Console.KeyAvailable == false)
                {
                    System.Threading.Thread.Sleep(10);
                }
                cki = Console.ReadKey(true);
                getinput = cki.Key.ToString();
                //Console.WriteLine(getinput.Substring(6));
                if (getinput.Length == 7)
                {
                    if ((getinput.Substring(6) != "w") || (getinput.Substring(6) != "l"))
                    {
                        getinput = getinput.Substring(6);
                    }
                }
            } while ((getinput.Length != 1));
            return getinput;
        }
        public static String LastAction = " ";
        public static int SetNumber = 0;
        public static bool Sureness = true;
        public static void VykonajAkciu(String s)
        {
            string getinput = GetPressedKey();
            switch (getinput)
            {
                case "b": //back
                    ClearMainPanel();ClearActionPanel();
                    MapWrite();
                    VypisAkcie("1");
                    VykonajAkciu("1");
                    break;
                case "B": //back

                    break;
                case "s": //save
                    break;
                case "S": //save
                    break;
                case "o": //options
                    break;
                case "O": //options
                    break;


               /* case "c": //online
                    ClearMainPanel();
                    VypisAkcie("1");
                    VykonajAkciu("1");
                    break;
                case "C": //online
                    ClearMainPanel();
                    VypisAkcie("1");
                    VykonajAkciu("1");
                    break;*/

                case "e": //exit
                    UpdateOnline();
                    Environment.Exit(0);
                    break;
                case "E": //exit
                    UpdateOnline();
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            switch (s)
            {
                case "YouSure":
                    switch (getinput)
                    {
                        case "1":
                            ClearActionPanel();
                            Sureness = true;
                            break;
                        case "2":
                            ClearActionPanel();
                            Sureness = false;
                            break;
                        default:
                            NevhodnyInput(); VypisAkcie("YouSure");
                            VykonajAkciu("YouSure");
                            break;
                    }
                    break;
                case "1":
                    switch (getinput)
                    {
                        case "1":
                            ClearMainPanel(); ClearActionPanel();
                            LastAction = " "; LastLineCount = 0;
                            break;
                        default:
                            NevhodnyInput(); VypisAkcie("1");
                            VykonajAkciu("1");
                            break;
                    }
                    break;
                case "Train1":
                    switch (getinput)
                    {
                        case "1":
                            Sila += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput; ;
                            break;
                        case "2":
                            Obrat += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "3":
                            Chari += 2; Intel += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "4":
                            Intel += 3; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        default:
                            NevhodnyInput();
                            break;
                    }
                    break;
                case "Train2":
                    switch (getinput)
                    {
                        case "1":
                            Sila += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput; ;
                            break;
                        case "2":
                            Obrat += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "3":
                            Chari += 2; Intel += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "4":
                            Intel += 3; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        default:
                            NevhodnyInput();
                            break;
                    }
                    break;
                case "Train3":
                    switch (getinput)
                    {
                        case "1":
                            Sila += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "2":
                            Obrat += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "3":
                            Chari += 2; Intel += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "4":
                            Intel += 3; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        default:
                            NevhodnyInput();
                            break;
                    }
                    break;
                case "Train4":
                    switch (getinput)
                    {
                        case "1":
                            Sila += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "2":
                            Obrat += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "3":
                            Chari += 2; Intel += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "4":
                            Intel += 3; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        default:
                            NevhodnyInput();
                            break;
                    }
                    break;
                case "Train5":
                    switch (getinput)
                    {
                        case "1":
                            Sila += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "2":
                            Obrat += 2; Vydrz += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "3":
                            Chari += 2; Intel += 1; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        case "4":
                            Intel += 3; Dni += RandomTimeMonth(); UpdateTandS(); LastAction = s + " " + getinput;
                            break;
                        default:
                            NevhodnyInput();
                            break;
                    }
                    break;
                case "Train6":
                    switch (getinput)
                    {
                        case "1":
                            ClearMainPanel(); ClearActionPanel();
                            LastAction = " ";
                            break;
                        default:
                            NevhodnyInput();
                            break;
                    }
                    break;           
                case "Shop":
                    switch (getinput)
                    {
                        case "1":
                            Shopping(1);
                            break;
                        case "2":
                            Shopping(2);
                            break;
                        case "3":
                            Shopping(3);
                            break;
                        case "4":
                            Shopping(4);
                            break;
                        case "5":
                            Shopping(5);
                            break;
                        case "6":
                            Shopping(6);
                            break;
                        case "7":
                            Shopping(7);
                            break;
                        case "8":
                            Shopping(8);
                            break;
                        default:
                            NevhodnyInput();
                            break;
                    }
                    break;
                case "main":
                    switch (getinput)
                    {
                        case "1": //job
                            
                            break;
                        case "2": //craft
                            
                            break;
                        case "3": //quest

                            break;
                        case "4": //relationships

                            break;
                        case "5": //training
                            ClearActionPanel();
                            VypisAkcie("Train" + Age().ToString());
                            VykonajAkciu("Train" + Age().ToString());
                            ClearMainPanel();
                            ClearActionPanel();
                            break;
                        case "6": //Shop
                            WriteShop(); 
                            VypisAkcie("ShopItemSelect");
                            VykonajAkciu("ShopItemSelect");
                            break;
                        case "7": //travel 
                            Traveling();
                            break;
                        case "8": //inventory
                            ClearMainPanel(); ClearActionPanel();
                            MapWrite();
                            Inventory();
                            break;
                        default:
                            NevhodnyInput();
                            break;
                    }
                    break;
                case "Inventory":
                    switch (getinput)
                    {
                        case "1": //swap item
                            ClearActionPanel();
                            VypisAkcie("InventoryItemSelectSwap");
                         tmp:
                            VykonajAkciu("GetNumber");
                            if (SetNumber == 9)
                            {
                                NevhodnyInput();
                                goto tmp;
                            }
                            double[] tmp1 = { 0.0, 0.0, 0.0, 0.0, 0.0 }; int[] tmp2 = { 0, 0, 0, 0, 0 };
                            Item tmpItem = new Item("", 0, 0, 0, tmp1, tmp2, 0, 0);
                            tmpItem = itemy[SetNumber - 1];
                            itemy[SetNumber - 1] = itemy[SetNumber + 7];
                            itemy[SetNumber + 7] = tmpItem;
                            break;
                        case "2": //sell item
                            ClearActionPanel();
                            VypisAkcie("InventoryItemSelectSell");
                        tmp1:
                            VykonajAkciu("GetNumber");
                            if (SetNumber == 9)
                            {
                                NevhodnyInput();
                                goto tmp1;
                            }
                            VypisAkcie("YouSure");
                            VykonajAkciu("YouSure");
                            if (Sureness)
                            {
                                double[] tmp12 = { 0.0, 0.0, 0.0, 0.0, 0.0 }; int[] tmp22 = { 0, 0, 0, 0, 0 };
                                Item tmpItem2 = new Item("", 0, 0, 0, tmp12, tmp22, 0, 0);
                                CopperCoinInput((int)Math.Round(itemy[SetNumber + 7].Value / 2.0));
                                itemy[SetNumber + 7] = tmpItem2;                               
                            }
                            break;
                        case "3": //disassemble item

                            break;
                        case "4": //remove item
                            ClearActionPanel();
                            VypisAkcie("InventoryItemSelectRemove");
                        tmp2:
                            VykonajAkciu("GetNumber");
                            if (SetNumber == 9)
                            {
                                NevhodnyInput();
                                goto tmp2;
                            }
                            VypisAkcie("YouSure");
                            VykonajAkciu("YouSure");
                            if (Sureness)
                            {
                                double[] tmp12 = { 0.0, 0.0, 0.0, 0.0, 0.0 }; int[] tmp22 = { 0, 0, 0, 0, 0 };
                                Item tmpItem2 = new Item("", 0, 0, 0, tmp12, tmp22, 0, 0);
                                itemy[SetNumber + 7] = tmpItem2;
                            }
                            break;
                        default:
                            NevhodnyInput(); VypisAkcie("Inventory");
                            VykonajAkciu("Inventory");
                            break;


                    }
                    ClearActionPanel();
                    ClearMainPanel();
                    UpdateStats();
                    break;
                case "ShopItemSelect":                    
                    switch (getinput)
                    {
                        case "1": case "2": case "3":case "4":case "5":case "6":case "7":case "8":case "9":
                            if (itemy[Int32.Parse(getinput) - 1].Name == "")
                            {
                                itemy[Int32.Parse(getinput) - 1] = shopitemy[Int32.Parse(getinput)];
                            }
                            else if (itemy[Int32.Parse(getinput) + 7].Name == "")
                            {
                                itemy[Int32.Parse(getinput) + 7] = shopitemy[Int32.Parse(getinput)];
                            }
                            else { Okno("There is no free slot for this type of item "); Okno("You need to remove one item from your inventory first"); }
                            ClearMainPanel();
                            ClearActionPanel();
                            UpdateStats();
                            break;
                        default:
                            NevhodnyInput();
                            VykonajAkciu("ShopItemSelect");
                            break;
                    }
                    break;
                case "GetNumber":
                    switch (getinput)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            SetNumber = Int32.Parse(getinput);
                            break;
                        default:
                            NevhodnyInput();
                            VykonajAkciu("GetNumber");
                            break;
                    }
                    break;
                case "LoginMissOrRegister":
                    switch (getinput)
                    {
                        case "1": Login();
                            break;
                        case "2": Register();
                            break;
                        default:
                            NevhodnyInput();
                            VykonajAkciu("LoginMissOrRegister");
                            break;
                    }
                    break;
                default:
                    Okno("NEEXISTUJUCI VARIANT AKCIE");
                    Okno("Toto by sa nemalo stať ale že nikdy :D");
                    break;
            }
        }
    }
}
