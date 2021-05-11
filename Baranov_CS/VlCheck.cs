using System;
using System.Globalization;
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

        public static DateTime safeReadDate(string message = "") {

            while (true) {

                string enteredDate = Console.ReadLine();

                if (DateTime.TryParseExact(enteredDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date)) {
                    return date;
                } else {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("(!) ERROR: uncorrect input a date.");
                    Console.Write("(->) Enter the date: ");
                }
            }
        }

        public static int inputOnlyPositiveIntNumber(int incoming_value) {

            while (!int.TryParse(Console.ReadLine(), out incoming_value) || incoming_value < 0) {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("(!) ERROR: non-integer or negative number entered.");
                Console.Write("(->) Enter the number:");
            }
            return incoming_value;
        }

        public static int inpuIntNumber(int incoming_value) {
            incoming_value = checkForNumberInput(incoming_value);
            return incoming_value;
        }

        public static int checkForNumberInput(int incoming_value) {
            while (!int.TryParse(Console.ReadLine(), out incoming_value)) {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("(!) ERROR: not an integer entered.");
                Console.Write("(->) Enter the number: ");
            }
            return incoming_value;
        }

        public static string stringReverse(string s) {
            return new string(s.Reverse().ToArray());
        }

        public static string readString(string message) {
            while (true) {
                string sValue = Console.ReadLine();
                return sValue;
            }
        }
    }
}
