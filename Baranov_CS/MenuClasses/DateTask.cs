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

            string list = madeList();

            if (list == "0 ") {
                Menu.infMessage = "Segments do not intersect";
            } else {
                Menu.infMessage = "From 0 to n: " + list;
            }
            Console.Clear();
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
            FirstDate = GetDate();
            Console.Write("(->) Enter the second date: ");
            SecondDate = GetDate();
            Console.Write("(->) Enter the third date: ");
            ThirdDate = GetDate();
            Console.Write("(->) Enter the fourth date: ");
            FourthDate = GetDate();
        }

        private DateTime GetDate() {

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

        private string madeList() {

            string list = "";
            int N = GetArgument();

            for (int i = 0; i <= Convert.ToInt32(N); i++) {
                list += Convert.ToString(i) + " ";
            }
            return list;
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
