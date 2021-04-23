using System;
using System.Linq;

namespace Baranov_CS {

    class VlCheck {

        public static int iValueCheck() {

            while (true) {
                string sValue; 
                int iValue;
                Console.WriteLine("----------------------------------------------");
                Console.Write("(->) Enter menu item number: ");
                sValue = Console.ReadLine();
                if (Int32.TryParse(sValue, out iValue)) {
                    return iValue;
                } else {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("(!) ERROR: not an integer entered.");
                }
            }
        }

        public static string StringReverse(string s) {
            return new string(s.Reverse().ToArray());
        }
    }
}
