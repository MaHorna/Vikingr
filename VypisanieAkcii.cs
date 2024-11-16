using System;
using static Vikingr.Metody;

namespace Vikingr
{
    class VypisanieAkcii
    {
        public static void VypisAkcie(String varianta)
        {
            int tmp1 = UI.FirstX[3] + 1;
            int tmp2 = UI.FirstY[3] + 1;
            int tmp3 = UI.FirstX[3] + 1 + 60;
            int tmp4 = UI.FirstX[3] + 1 + 120;
            switch (varianta)
            {
                case "main":             
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Job");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("2) Craft");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("3) Quests");
                    Gotoxy(tmp1, tmp2 + 3);
                    Console.WriteLine("4) Relationships");

                    Gotoxy(tmp3, tmp2);
                    Console.WriteLine("5) Training");
                    Gotoxy(tmp3, tmp2 + 1);
                    Console.WriteLine("6) Shop");
                    Gotoxy(tmp3, tmp2 + 2);
                    Console.WriteLine("7) Travel");
                    Gotoxy(tmp3, tmp2 + 3);
                    Console.WriteLine("8) Inventory and Map");
                    break;
                case "1"://dalej
                    UpdateWindows.ClearActionPanel();                    
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Continue");
                    SQL.CountOnlinePlayers();
                    break;
                case "YouSure"://dalej
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("Are you sure?");
                    Gotoxy(tmp1, tmp2+1);
                    Console.WriteLine("1) Yes");
                    Gotoxy(tmp1, tmp2+2);
                    Console.WriteLine("2) No");

                    break;
                case "Train1"://batola akcie
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Play with sticks          + 2 Strength + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("2) Chase the hens            + 2 Dexterity + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("3) Play with other children  + 2 Charisma + 1 Inteligence");
                    Gotoxy(tmp1, tmp2 + 3);
                    Console.WriteLine("4) Count some rocks          + 3 Inteligence");
                    break;
                case "Train2"://dieta akcie
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Train with wooden sword   + 2 Strength + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("2) Chase your friends        + 2 Dexterity + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("3) Chat with friends         + 2 Charisma + 1 Inteligence");
                    Gotoxy(tmp1, tmp2 + 3);
                    Console.WriteLine("4) Learn from elder          + 3 Inteligence");
                    break;
                case "Train3"://teen akcie
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Fight a bit               + 2 Strength + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("2) Dexterity training        + 2 Dexterity + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("3) Chat with friends         + 2 Charisma + 1 Inteligence");
                    Gotoxy(tmp1, tmp2 + 3);
                    Console.WriteLine("4) Learn from elder          + 3 Inteligence");
                    break;
                case "Train4"://dospely akcie
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Fight a bit               + 2 Strength + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("2) Dexterity training        + 2 Dexterity + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("3) Chat with friends         + 2 Charisma + 1 Inteligence");
                    Gotoxy(tmp1, tmp2 + 3);
                    Console.WriteLine("4) Learn from elder          + 3 Inteligence");
                    break;
                case "Train5"://dospely akcie
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Fight a bit               + 2 Strength + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("2) Dexterity training        + 2 Dexterity + 1 Constitution");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("3) Chat with friends         + 2 Charisma + 1 Inteligence");
                    Gotoxy(tmp1, tmp2 + 3);
                    Console.WriteLine("4) Learn from elder          + 3 Inteligence");
                    break;
                case "Train6"://dospely akcie
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("You are too weak to train. ");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("You have nothing to learn from others");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("1) Continue");
                    break;
                case "VyberCharakteru"://file handle akcie
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1..9) Výber postavy");
                    break;
                case "Shop":
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Helmets        2) Chest Armor");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("3) Gloves         4) Pants");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("5) Boots          6) Left Hand");
                    Gotoxy(tmp1, tmp2 + 3);
                    Console.WriteLine("7) Right Hand     8) Accesories");
                    break;
                case "Inventory"://inv
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1) Swap Item");
                    Gotoxy(tmp1, tmp2+1);
                    Console.WriteLine("2) Sell Item");
                    Gotoxy(tmp1, tmp2+2);
                    Console.WriteLine("3) Disassemble Item");
                    Gotoxy(tmp1, tmp2+3);
                    Console.WriteLine("4) Remove Item");
                    break;
                case "ShopItemSelect":
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1..9) Item's number ");
                    break;
                case "InventoryItemSelectSwap":
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1..9) Swap: Item's number ");
                    break;
                case "InventoryItemSelectSell":
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1..9) Sell: Item's number");
                    Gotoxy(tmp1, tmp2+1);
                    Console.WriteLine("You can only sell items you have stored");
                    Gotoxy(tmp1, tmp2+2);
                    Console.WriteLine("If you want to sell items wearing - swap first");
                    break;
                case "InventoryItemSelectDisassemble":
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1..9) Disassemble: Item's number ");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("You can only disassemble items you have stored");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("If you want to disassemble items wearing - swap first");
                    break;
                case "InventoryItemSelectRemove":
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("1..9) Remove: Item's number ");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("You can only remove items you have stored");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("If you want to remove items wearing - swap first");
                    break;
                case "LoginMissOrRegister":
                    UpdateWindows.ClearActionPanel();
                    Gotoxy(tmp1, tmp2);
                    Console.WriteLine("There is no user with such name and password combination");
                    Gotoxy(tmp1, tmp2 + 1);
                    Console.WriteLine("1) Try again");
                    Gotoxy(tmp1, tmp2 + 2);
                    Console.WriteLine("2) Create new account with this Name and Password");
                    break;
                default:
                    break;
            }

            Gotoxy(tmp4, tmp2);
            Console.WriteLine("B) Back");
            Gotoxy(tmp4, tmp2 + 1);
            Console.WriteLine("S) Save Game");
            Gotoxy(tmp4, tmp2 + 2);
            Console.WriteLine("O) Options");
            Gotoxy(tmp4, tmp2 + 3);
            Console.WriteLine("E) Save & Exit");
        }
    }
}
