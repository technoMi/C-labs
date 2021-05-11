using System;
using System.Collections.Generic;
using Baranov_CS.MenuClasses;

namespace Baranov_CS {

    class Menu {

        private static List<Core> MenuItems = new List<Core>();

        private static string infMessage = "Here will be information";

        ///
        public static void ClearItems() {
            Menu.MenuItems.ForEach((mi) => { mi.OnInfoUpdate -= MenuInfoUpdateHandler; });
            Menu.MenuItems.Clear();
        }

        public static void AddItem(Core menuItem) {
            Menu.MenuItems.Add(menuItem);
            menuItem.OnInfoUpdate += MenuInfoUpdateHandler;
        }
        ///

        private static void MenuInfoUpdateHandler(string info) {
            Menu.infMessage = info;
        }

        public static void Execute() {
            showMenu();
            int menu_item = VlCheck.iValueCheck();
            while (!(menu_item >= 0 && menu_item < Menu.MenuItems.Count)) {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("(!) No such menu item exists.");
                Console.WriteLine("Please, enter '0', '1', '2', '3', or '4'. ");
                menu_item = VlCheck.iValueCheck();
            }
            Menu.MenuItems.ToArray()[menu_item].Execute();
        }

        private static void showMenu() {

            Console.Clear();

            int iMenuItem = 0;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(infMessage);
            Console.WriteLine("----------------------------------------------");

            foreach (Core menuItem in Menu.MenuItems) {
                Console.WriteLine("[{0}] {1}", iMenuItem++, menuItem.Title);
            }
        }
    }
}
