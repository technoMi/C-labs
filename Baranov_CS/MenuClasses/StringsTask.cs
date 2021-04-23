using Baranov_CS.Validation;
using System;

namespace Baranov_CS.MenuClasses {

    class StringsTask : Core {

        string the_first_string;
        string the_second_string;

        public override string Title {
            get {
                return "Strings.";
            }
        }

        public override void Execute() {
            stringRequest();
            results();
        }

        private void stringRequest() {
            Console.WriteLine("Input the first string: ");
            the_first_string = Console.ReadLine();
            Console.WriteLine("Input the second string: ");
            the_second_string = Console.ReadLine();
        }

        private void results() {
            try {
                StringValidation.AreEqual(the_first_string, the_second_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage = ex.Message;
            }

            try {
                StringValidation.SpaceRemove(the_first_string, the_second_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage += ex.Message;
            }

            try {
                StringValidation.StringReverse(the_first_string, the_second_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage += ex.Message;
            }

            try {
                StringValidation.IsEmail(the_first_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage += ex.Message;
            }

            try {
                StringValidation.IsEmail(the_second_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage += ex.Message;
            }

            try {
                StringValidation.IsPhoneNumber(the_first_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage += ex.Message;
            }

            try {
                StringValidation.IsPhoneNumber(the_second_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage += ex.Message;
            }

            try {
                StringValidation.IsIPAddress(the_first_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage += ex.Message;
            }

            try {
                StringValidation.IsIPAddress(the_second_string);
            }
            catch (ValidationException ex) {
                Menu.infMessage += ex.Message;
                Console.Clear();
            }
        }
    }
}
