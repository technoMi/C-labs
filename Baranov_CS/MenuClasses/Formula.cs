using System;
using System.Collections.Generic;
using System.Text;

namespace Baranov_CS.MenuClasses {

    class Formula : Core {

        private double calcResult;

        public override string Title {
            get {
                return "Calc: Y^3+3*sqrt(X)+Z";
            }
        }

        public override void Execute() {
            numbersRequest();
            Console.Clear();
        }

        private void numbersRequest() {

            int X = 0, Y = 0, Z = 0;

            Console.WriteLine("==============================================");
            Console.Write("(->) Enter the number X: ");
            X = inputOnlyPositiveIntNumber(X);

            Console.Write("(->) Enter the number Y: ");
            Y = inpuIntNumber(Y);

            Console.Write("(->) Enter the number Z: ");
            Z = inpuIntNumber(Z);

            calcResult = (Math.Pow(Y, 3) + (3 * Math.Sqrt(X)) + Z);
            Menu.infMessage = Y + "^3+3*sqrt(" + X + ")+" + Z + " = " + calcResult.ToString("F" + 3);
        }

        public static int checkForNumberInput(int incoming_value) {
            while (!int.TryParse(Console.ReadLine(), out incoming_value)) {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("(!) ERROR: not an integer entered.");
                Console.Write("(->) Enter the number: ");
            }
            return incoming_value;
        }

        public static int inpuIntNumber(int incoming_value) {
            incoming_value = checkForNumberInput(incoming_value);
            return incoming_value;
        }

        public static int inputOnlyPositiveIntNumber(int incoming_value) {

            while (!int.TryParse(Console.ReadLine(), out incoming_value) || incoming_value < 0) {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("(!) ERROR: non-integer or negative number entered.");
                Console.Write("(->) Enter the number:");
            }
            return incoming_value;
        }
    }
}
