using System;

namespace Baranov_CS.MenuClasses { 

    class Helloworld : Core {

        public override string Title {
            get {
                return "Hello world!";
            }
        }

        public override void Execute() {
            Menu.infMessage = "Hello world!";
            Console.Clear();
        }
    }
}
