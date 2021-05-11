using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Baranov_CS.Validation {

    class StringValidation : Exception {

        ///
        public static void areEqual(string s1, string s2) {

            if (!s1.Equals(s2)) {
                throw new ValidationException("- Strings aren't equal.\n");
            }
        }
        ///

        public static void stringReverse(string s1, string s2) {

            string s = new string(s1.Reverse().ToArray());
            if (!s.Equals(s2)) {
                throw new ValidationException("- Strings aren't  inverse.\n");
            }
        }

        public static void spaceRemove(string s1, string s2) {

            s1 = s1.Trim().ToLower();
            s1 = Regex.Replace(s1, @"\s+", " ");

            s2 = s2.Trim().ToLower();
            s2 = Regex.Replace(s2, @"\s+", " ");

            if (s1.Equals(s2)) {
            } else {
                throw new ValidationException("- Strings are not equal after converting them to the same case, removing " +
                    "\n  duplicate spaces, and removing leading and trailing spaces.\n");
            }
        }

        public static void isEmail(string str) {

            if (Regex.IsMatch(str, "[^@ \t\r\n]+@[^@ \t\r\n]+\\.[^@ \t\r\n]+")) {
            } else {
                string message = $"- The string '{str}' isn't email.\n";
                throw new ValidationException(message);
            }
        }

        public static void isPhoneNumber(string str) {

            if (Regex.IsMatch(str, "\\+? ?3?[ -]?8?[ -]?\\(?(\\d[ -]?){3}\\)?[ -]?(\\d[ -]?){7}")) {
            } else {
                string message = $"- The string '{str}' isn't phone number.\n";
                throw new ValidationException(message);
            }
        }

        public static void isIPAddress(string str) {

            if (Regex.IsMatch(str, "^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")) {
            } else {
                string message = $"- The string '{str}' isn't IP-address.\n";
                throw new ValidationException(message);
            }
        }
    }
}