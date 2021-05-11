using Baranov_CS.Validation;
using System;

namespace Baranov_CS.MenuClasses {

    class StringsTask : Core {

        public override string Title {
            get {
                return "Strings.";
            }
        }

        string the_first_string = "";
        string the_second_string = "";

        public override void Execute() {
            stringRequest();
            results();
        }

        private void stringRequest() {
            Console.Write("Input the first string: ");
            the_first_string = VlCheck.readString(the_first_string);
            Console.Write("Input the second string: ");
            the_second_string = VlCheck.readString(the_second_string);
        }

        private void results() {

            string message = "";

            /////////////////////////////
            try {
                StringValidation.areEqual(the_first_string, the_second_string);
                message += "- Strings are equal.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }
            /////////////////////////////

            try {
                StringValidation.spaceRemove(the_first_string, the_second_string);
                message += "- Strings are equal after converting them to the same case, removing " +
                    "\n  duplicate spaces, and removing leading and trailing spaces.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }

            try {
                StringValidation.stringReverse(the_first_string, the_second_string);
                message += "- Strings are inverse.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }

            try {
                StringValidation.isEmail(the_first_string);
                message += $"- The string '{the_first_string}' is email.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }

            try {
                StringValidation.isEmail(the_second_string);
                message += $"- The string '{the_second_string}' is email.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }

            try {
                StringValidation.isPhoneNumber(the_first_string);
                message += $"- The stirng '{the_first_string}' is phone number.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }

            try {
                StringValidation.isPhoneNumber(the_second_string);
                message += $"- The stirng '{the_second_string}' is phone number.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }

            try {
                StringValidation.isIPAddress(the_first_string);
                message += $"- The string '{the_first_string}' is IP-address.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }

            try {
                StringValidation.isIPAddress(the_second_string);
                message += $"- The string '{the_second_string}' is IP-address.\n";
            }
            catch (ValidationException ex) {
                message += ex.Message;
            }

            FireInfoUpdate(message);
        }
    }
}

/*
 * try {
                StringValidation.isIPAddress(the_second_string);
                FireInfoUpdate($"- The string '{the_second_string}' is IP-address.\n");
            }
            catch (ValidationException ex) {
                FireInfoUpdate(ex.Message);
                Console.Clear(); //перенести
            }
 */
