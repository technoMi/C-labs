using System;
using System.Collections.Generic;
using System.Text;

namespace Baranov_CS.MenuClasses {

    class MenItExit : Core {

        public override string Title {
            get {
                return "Exit.";
            }
        }

        public override void Execute() {
            Console.WriteLine("Выход из программы\n");
            Environment.Exit(0);
        }
    }
}