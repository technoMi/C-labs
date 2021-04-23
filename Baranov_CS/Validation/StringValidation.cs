using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Baranov_CS.Validation {

    class StringValidation : Exception {

        public static void AreEqual(string s1, string s2) {

            if (s1.Equals(s2)) {
                Menu.infMessage = "- Strings are equal.\n";
            } else {
                throw new ValidationException("- Strings aren't equal.\n");
            }
        }

        public static void StringReverse(string s1, string s2) {

            string s = new string(s1.Reverse().ToArray());
            if (s.Equals(s2)) {
                Menu.infMessage += "- Strings are inverse.\n";
            } else {
                throw new ValidationException("- Strings aren't  inverse.\n");
            }
        }

        public static void SpaceRemove(string s1, string s2) {

            s1 = s1.Trim().ToLower();
            s1 = Regex.Replace(s1, @"\s+", " ");

            s2 = s2.Trim().ToLower();
            s2 = Regex.Replace(s2, @"\s+", " ");

            if (s1.Equals(s2)) {
                Menu.infMessage += "- Strings are equal after converting them to the same case, removing " +
                    "\n  duplicate spaces, and removing leading and trailing spaces.\n";
            } else {
                throw new ValidationException("- Strings are not equal after converting them to the same case, removing " +
                    "\n  duplicate spaces, and removing leading and trailing spaces.\n");
            }
        }

        public static void IsEmail(string str) {

            if (Regex.IsMatch(str, "[^@ \t\r\n]+@[^@ \t\r\n]+\\.[^@ \t\r\n]+")) {
                Menu.infMessage += $"- The string '{str}' is email.\n";
            } else {
                string message = $"- The string '{str}' isn't email.\n";
                throw new ValidationException(message);
            }
        }

        public static void IsPhoneNumber(string str) {

            if (Regex.IsMatch(str, "\\+? ?3?[ -]?8?[ -]?\\(?(\\d[ -]?){3}\\)?[ -]?(\\d[ -]?){7}")) {
                Menu.infMessage += $"- The stirng '{str}' is phone number.\n";
            } else {
                string message = $"- The string '{str}' isn't phone number.\n";
                throw new ValidationException(message);
            }
        }

        public static void IsIPAddress(string str) {

            if (Regex.IsMatch(str, "^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")) {
                Menu.infMessage += $"- The string '{str}' is IP-address.\n";
            } else {
                string message = $"- The string '{str}' isn't IP-address.\n";
                throw new ValidationException(message);
            }
        }
    }
}