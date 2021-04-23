using Baranov_CS.MenuClasses;

namespace Baranov_CS {

    class Program {

        static void Main(string[] args) {

            Menu.ClearItems();
            Menu.AddItem(new MenItExit());
            Menu.AddItem(new Helloworld());
            Menu.AddItem(new Formula());
            Menu.AddItem(new DateTask());
            Menu.AddItem(new StringsTask());

            while (true) {
                Menu.Execute();
            }
        }
    }
}