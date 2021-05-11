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
        }

        private void numbersRequest() {

            int X = 0, Y = 0, Z = 0;

            Console.WriteLine("==============================================");
            Console.Write("(->) Enter the number X: ");
            X = VlCheck.inputOnlyPositiveIntNumber(X);

            Console.Write("(->) Enter the number Y: ");
            Y = VlCheck.inpuIntNumber(Y);

            Console.Write("(->) Enter the number Z: ");
            Z = VlCheck.inpuIntNumber(Z);

            calcResult = (Math.Pow(Y, 3) + (3 * Math.Sqrt(X)) + Z);
            FireInfoUpdate(Y + "^3+3*sqrt(" + X + ")+" + Z + " = " + calcResult.ToString("F" + 3));
        }
    }
}
