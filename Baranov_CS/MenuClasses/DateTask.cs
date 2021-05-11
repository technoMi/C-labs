using System;
using System.Globalization;

namespace Baranov_CS.MenuClasses {

    class DateTask : Core {

        private DateTime FirstDate;
        private DateTime SecondDate;
        private DateTime ThirdDate;
        private DateTime FourthDate;

        public override string Title {
            get {
                return "Date Task.";
            }
        }

        public override void Execute() {

            drawInterface();

            inputDate();

            if (madeList() == "0 ") {
                FireInfoUpdate("Segments do not intersect");
            } else if (madeList() == "n mnogo"){
                FireInfoUpdate("n mnogo");
            } else {
                FireInfoUpdate("From 0 to n: " + madeList());
            }
        }
 
        public void drawInterface() {
            Console.WriteLine("==============================================");
            Console.WriteLine("The first date must be less than second and");
            Console.WriteLine("third date must be less than fourth.");
            Console.WriteLine("(?) Example input: DD.MM.YYYY.");
            Console.WriteLine("----------------------------------------------");
        }

        private void inputDate() {
            Console.Write("(->) Enter the First date: ");
            FirstDate = VlCheck.safeReadDate();
            Console.Write("(->) Enter the second date: ");
            SecondDate = VlCheck.safeReadDate();
            while (FirstDate > SecondDate) {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("(!) ERROR: uncorrect input a date.");
                Console.Write("(->) Enter the First date: ");
                FirstDate = VlCheck.safeReadDate();
                Console.Write("(->) Enter the Second date: ");
                SecondDate = VlCheck.safeReadDate();
            }
            Console.Write("(->) Enter the third date: ");
            ThirdDate = VlCheck.safeReadDate();
            Console.Write("(->) Enter the fourth date: ");
            FourthDate = VlCheck.safeReadDate();
            while (ThirdDate > FourthDate) {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("(!) ERROR: uncorrect input a date.");
                Console.Write("(->) Enter the Third date: ");
                ThirdDate = VlCheck.safeReadDate();
                Console.Write("(->) Enter the Fourth date: ");
                FourthDate = VlCheck.safeReadDate();
            }
        }

        private string madeList() {

            string list = "";
            int N = GetArgument();
            int arg_constraint = 10000;

            if (N < arg_constraint) {
                for (int i = 0; i <= Convert.ToInt32(N); i++) {
                    list += Convert.ToString(i) + " ";
                }
                return list;
            } else {
                return "Argument n is too big.";
            }
        }

        private int GetArgument() {

            int n;

            if (SecondDate >= FourthDate && FirstDate >= ThirdDate && FourthDate >= FirstDate) {
                n = Convert.ToInt32((FourthDate - FirstDate).TotalDays) + 1;
            } else if (SecondDate >= FourthDate && ThirdDate >= FirstDate) {
                n = Convert.ToInt32((FourthDate - ThirdDate).TotalDays) + 1;
            } else if (FourthDate >= SecondDate && ThirdDate >= FirstDate && SecondDate >= ThirdDate) {
                n = Convert.ToInt32((SecondDate - ThirdDate).TotalDays) + 1;
            } else if (FourthDate >= SecondDate && FirstDate >= ThirdDate) {
                n = Convert.ToInt32((SecondDate - FirstDate).TotalDays) + 1;
            } else {
                n = 0;
            }
            return n;
        }
    }
 }
